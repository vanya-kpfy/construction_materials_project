using branch_for_registration_1.Classes;
using branch_for_registration_1.UsersServices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using branch_for_registration_1.ValidationTextBox;
using branch_for_registration_1.DTO;

namespace branch_for_registration_1.Forms
{
    /// <summary>
    /// Главная форма приложения: каталог товаров, фильтрация по категориям, поиск, отгрузка, админ‑панель
    /// </summary>
    public partial class FormMain : Form
    {
        private string userEmail;
        private string userRole;
        private WorkingWithUsers userService;
        private CategoryService categoryService;
        private ProductService productService;
        private Guid currentUserId;
        public static List<ProductDto> LastSearchResults { get; set; }

        // Словарь для быстрого поиска ID категории по названию (остаётся)
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

            // Загружаем кнопки категорий (динамически)
            LoadCategoryButtons();

            // По умолчанию показываем все товары
            LoadAllProducts();

            // Подписываемся на события кнопок (существующие кнопки из дизайнера)
            SubscribeButtons();
        }

        /// <summary>
        /// Загружает соответствие названий категорий и их GUID из базы данных.
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
        /// Создаёт кнопки для каждой категории и добавляет их в панель.
        /// </summary>
        private void LoadCategoryButtons()
        {
            pnlCategories.Controls.Clear();
            var categories = categoryService.GetAllCategories();

            int y = 5; 
            foreach (var cat in categories)
            {
                var btn = new Button
                {
                    Text = cat.Name,
                    Tag = cat.Id,
                    Width = pnlCategories.Width - 10,
                    Height = 35,
                    FlatStyle = FlatStyle.Flat,
                    FlatAppearance = { BorderSize = 0 },
                    Margin = new Padding(5),
                    BackColor = Color.LightGray,
                    ForeColor = Color.Black,
                    TextAlign = ContentAlignment.MiddleLeft, // прижимаем текст влево
                    Location = new Point(5, y)               
                };
                btn.Click += (s, e) => LoadProductsByCategoryId((Guid)((Button)s).Tag);
                pnlCategories.Controls.Add(btn);
                y += btn.Height + 5; // увеличиваем Y для следующей кнопки
            }
        }

        /// <summary>
        /// Загружает товары по ID категории
        /// </summary>
        private void LoadProductsByCategoryId(Guid categoryId)
        {
            var products = productService.GetProductsByCategory(categoryId);
            FillProductGrid(products);
        }

        /// <summary>
        /// Подписывает обработчики на статические кнопки (все товары, поиск, отгрузка, админ, выход)
        /// </summary>
        private void SubscribeButtons()
        {
            // Кнопка "Все товары"
            if (btnAllProducts != null)
            {
                btnAllProducts.Click += (s, e) => LoadAllProducts();
            }

            buttonSearch.Click += (s, e) =>
            {
                using (var searchForm = new FormSearch(productService))
                {
                    if (searchForm.ShowDialog() == DialogResult.OK)
                    {
                        var products = productService.SearchProductsAdvanced(searchForm.Article,searchForm.ProductName,searchForm.CategoryId
                        );
                        FillProductGrid(products);
                    }
                }
            };

            buttonShipment.Click += (s, e) =>
            {
                var shipmentForm = new FormShipment(currentUserId);
                shipmentForm.ShowDialog();
                LoadAllProducts(); // обновляем остатки
            };

            buttonAdmin.Click += (s, e) =>
            {
                var adminForm = new FormAdmin();
                adminForm.ShowDialog();
                LoadCategoryIds();
                LoadCategoryButtons();  
                LoadAllProducts();
            };

            // Выход
            buttonLogout.Click += (s, e) => this.Close();
        }

        /// <summary>
        /// Загружает все товары
        /// </summary>
        private void LoadAllProducts()
        {
            var products = productService.GetProducts();
            FillProductGrid(products);
        }

        /// <summary>
        /// Заполняет таблицу товаров
        /// </summary>
        private void FillProductGrid(List<ProductDto> products)
        {
            dgvProducts.Rows.Clear();
            dgvProducts.Columns.Clear();

            dgvProducts.Columns.Add("Article", LanguageHelper.GetString("Article"));
            dgvProducts.Columns.Add("Name", LanguageHelper.GetString("Name"));
            dgvProducts.Columns.Add("Category", LanguageHelper.GetString("Category"));
            dgvProducts.Columns.Add("Unit", LanguageHelper.GetString("Unit"));
            dgvProducts.Columns.Add("Price", LanguageHelper.GetString("Price"));
            dgvProducts.Columns.Add("Stock", LanguageHelper.GetString("Stock"));

            foreach (var p in products)
            {
                dgvProducts.Rows.Add(p.Article,p.Name,p.CategoryName,p.Unit,p.PurchasePrice.ToString("F2"),p.CurrentStock);
            }

            // Настройка ширины колонок
            if (dgvProducts.Columns.Count >= 6)
            {
                dgvProducts.Columns["Article"].Width = 80;
                dgvProducts.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvProducts.Columns["Category"].Width = 100;
                dgvProducts.Columns["Unit"].Width = 60;
                dgvProducts.Columns["Price"].Width = 80;
                dgvProducts.Columns["Stock"].Width = 60;
            }
        }

        /// <summary>
        /// Настраивает внешний вид таблицы
        /// </summary>
        private void SetupDataGridViewStyle()
        {
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProducts.ColumnHeadersHeight = 45;
            dgvProducts.EnableHeadersVisualStyles = false;
            dgvProducts.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProducts.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgvProducts.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;

            dgvProducts.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvProducts.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProducts.RowsDefaultCellStyle.BackColor = Color.White;
            dgvProducts.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            dgvProducts.RowHeadersVisible = false;
            dgvProducts.AllowUserToResizeRows = false;
            dgvProducts.AllowUserToResizeColumns = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProducts.ReadOnly = true;
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.BackgroundColor = this.BackColor;
            dgvProducts.CellBorderStyle = DataGridViewCellBorderStyle.None;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            new FormLogin().Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            categoryService.Dispose();
            productService.Dispose();
            base.OnFormClosing(e);
        }
    }
}