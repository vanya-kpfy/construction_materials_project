using branch_for_registration_1.Classes;
using branch_for_registration_1.UsersServices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace branch_for_registration_1.Forms
{
    /// <summary>
    /// Форма главной страницы (там куда попадют после регистрации и авторизации, попадают все без исключения)
    /// </summary>
    public partial class FormMain : Form
    {
        private string userEmail;
        private string userRole;
        private WorkingWithUsers userService;
        private CategoryService categoryService;
        private ProductService productService;
        private Guid currentUserId;

        // Ссылки на категории (получаем из БД)
        private Dictionary<string, Guid> categoryIds;

        public FormMain(string email, string role)
        {
            InitializeComponent();

            userEmail = email;
            userRole = role;
            userService = new WorkingWithUsers();
            categoryService = new CategoryService();
            productService = new ProductService();

            var user = userService.GetUserByEmail(email);
            currentUserId = user?.Id ?? Guid.Empty;

            // Показываем кнопку админа только для администратора
            buttonAdmin.Visible = (role == "Admin");

            // Настраиваем внешний вид таблицы
            SetupDataGridViewStyle();

            // Загружаем идентификаторы категорий
            LoadCategoryIds();

            // Подписываемся на события кнопок (если не подписаны в дизайнере)
            SubscribeButtons();

            // По умолчанию показываем все товары
            LoadAllProducts();
        }

        /// <summary>
        /// Загружает соответствие названий категорий и их GUID из базы данных
        /// </summary>
        private void LoadCategoryIds()
        {
            categoryIds = new Dictionary<string, Guid>();
            var categories = categoryService.GetAllCategories();
            foreach (var cat in categories)
            {
                categoryIds[cat.Name] = cat.Id;
            }
        }

        /// <summary>
        /// Подписывает обработчики на кнопки категорий
        /// </summary>
        private void SubscribeButtons()
        {
            // Кнопка "Все товары"
            if (btnAllProducts != null)
            {
                btnAllProducts.Click += (s, e) => LoadAllProducts();
            }

            // Кнопки для каждой категории
            if (btnListovyeMaterialy != null)
            {
                btnListovyeMaterialy.Click += (s, e) => LoadProductsByCategoryName("Листовые материалы");
            }
            if (btnSuhieSmesi != null)
            {
                btnSuhieSmesi.Click += (s, e) => LoadProductsByCategoryName("Сухие смеси и грунтовки");
            }
            if (btnTeploizolyaciya != null)
            {
                btnTeploizolyaciya.Click += (s, e) => LoadProductsByCategoryName("Теплоизоляция");
            }
            if (btnBloki != null)
            {
                btnBloki.Click += (s, e) => LoadProductsByCategoryName("Блоки для строительства");
            }
            if (btnMetalloprokat != null)
            {
                btnMetalloprokat.Click += (s, e) => LoadProductsByCategoryName("Металлопрокат");
            }
            if (btnKrovlya != null)
            {
                btnKrovlya.Click += (s, e) => LoadProductsByCategoryName("Кровля");
            }
            if (btnFasadnyeMaterialy != null)
            {
                btnFasadnyeMaterialy.Click += (s, e) => LoadProductsByCategoryName("Фасадные материалы");
            }
            if (btnProfil != null)
            {
                btnProfil.Click += (s, e) => LoadProductsByCategoryName("Профиль для гипсокартона и аксессуары");
            }
            if (btnStroitelnyeMaterialy != null)
            {
                btnStroitelnyeMaterialy.Click += (s, e) => LoadProductsByCategoryName("Строительные и расходные материалы");
            }
            if (btnShumoizolyaciya != null)
            {
                btnShumoizolyaciya.Click += (s, e) => LoadProductsByCategoryName("Шумоизоляция");
            }
            if (btnParoizolyaciya != null)
            {
                btnParoizolyaciya.Click += (s, e) => LoadProductsByCategoryName("Ветро-влагозащита и пароизоляция кровли и фасадов");
            }
        }

        /// <summary>
        /// Загружает товары по названию категории.
        /// </summary>
        private void LoadProductsByCategoryName(string categoryName)
        {
            if (categoryIds.TryGetValue(categoryName, out Guid catId))
            {
                var products = productService.GetProductsByCategory(catId);
                FillProductGrid(products);
            }
            else
            {
                MessageBox.Show($"Категория '{categoryName}' не найдена в базе данных.", "Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Загружает все товары.
        /// </summary>
        private void LoadAllProducts()
        {
            var products = productService.GetAllProducts();
            FillProductGrid(products);
        }

        /// <summary>
        /// Заполняет таблицу товаров.
        /// </summary>
        private void FillProductGrid(List<Product> products)
        {
            dataGridViewProducts.Rows.Clear();
            dataGridViewProducts.Columns.Clear();

            dataGridViewProducts.Columns.Add("Article", "Артикул");
            dataGridViewProducts.Columns.Add("Name", "Название");
            dataGridViewProducts.Columns.Add("Category", "Категория");
            dataGridViewProducts.Columns.Add("Unit", "Единица измерения");
            dataGridViewProducts.Columns.Add("Price", "Цена закупки");
            dataGridViewProducts.Columns.Add("Stock", "Остаток");

            foreach (var p in products)
            {
                dataGridViewProducts.Rows.Add(p.Article,p.Name,p.Category?.Name,p.Unit,p.PurchasePrice.ToString("F2"),p.CurrentStock);
            }

            // Настройка ширины колонок
            if (dataGridViewProducts.Columns.Count >= 6)
            {
                dataGridViewProducts.Columns["Article"].Width = 80;
                dataGridViewProducts.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewProducts.Columns["Category"].Width = 100;
                dataGridViewProducts.Columns["Unit"].Width = 60;
                dataGridViewProducts.Columns["Price"].Width = 80;
                dataGridViewProducts.Columns["Stock"].Width = 60;
            }
        }

        /// <summary>
        /// Настраивает внешний вид таблицы
        /// </summary>
        private void SetupDataGridViewStyle()
        {
            //// Фон добавлен из ресурсов, но почему то не работает, модет версия программной среды у меня устарело((
            //try
            //{
            //    dataGridViewProducts.BackgroundImage = Properties.Resources.FonQW;
            //    dataGridViewProducts.BackgroundImageLayout = ImageLayout.Stretch;
            //}
            //catch
            //{
            //    dataGridViewProducts.BackgroundColor = Color.White;
            //}
            
            // Это запасное оформление
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewProducts.ColumnHeadersHeight = 45;
            dataGridViewProducts.EnableHeadersVisualStyles = false;
            dataGridViewProducts.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewProducts.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dataGridViewProducts.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSteelBlue;

            dataGridViewProducts.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridViewProducts.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewProducts.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridViewProducts.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            dataGridViewProducts.RowHeadersVisible = false;
            dataGridViewProducts.AllowUserToResizeRows = false;
            dataGridViewProducts.AllowUserToResizeColumns = false;
            dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProducts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewProducts.ReadOnly = true;
            dataGridViewProducts.AllowUserToAddRows = false;
            dataGridViewProducts.BackgroundColor = this.BackColor;
            dataGridViewProducts.CellBorderStyle = DataGridViewCellBorderStyle.None;
        }

        // ---------- Остальные обработчики (поиск, отгрузка, админ, выход) ----------
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            using (var searchForm = new FormSearch())
            {
                if (searchForm.ShowDialog() == DialogResult.OK)
                {
                    var products = productService.SearchProductsAdvanced(
                        searchForm.Article,
                        searchForm.ProductName,
                        searchForm.CategoryId
                    );
                    FillProductGrid(products);
                }
            }
        }

        private void buttonShipment_Click(object sender, EventArgs e)
        {
            var shipmentForm = new FormShipment(currentUserId);
            shipmentForm.ShowDialog();
            LoadAllProducts(); // обновляем остатки после отгрузки
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            var adminForm = new FormAdmin();
            adminForm.ShowDialog();
            // После закрытия админки обновляем список категорий и товаров
            LoadCategoryIds();          // перезагружаем ID категорий (на случай изменений)
            LoadAllProducts();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            new FormLogin().Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            userService.Dispose();
            categoryService.Dispose();
            productService.Dispose();
            base.OnFormClosing(e);
        }
    }
}