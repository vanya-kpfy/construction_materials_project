using branch_for_registration_1.UsersServices;
using branch_for_registration_1.ValidationTextBox;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace branch_for_registration_1.Forms
{
    /// <summary>
    /// Административная панель: управление пользователями, товарами, категориями, история отгрузок.
    /// </summary>
    public partial class FormAdmin : Form
    {
        private WorkingWithUsers userService;
        private ProductService productService;
        private CategoryService categoryService;
        private ShipmentService shipmentService;
        private DataGridView dgvProducts;

        // Текущий активный раздел (DataGridView или другой контрол)
        private Control currentSection;

        public FormAdmin()
        {
            InitializeComponent();

            userService = new WorkingWithUsers();
            productService = new ProductService();
            categoryService = new CategoryService();
            shipmentService = new ShipmentService();

            // Подписываемся на события кнопок (кнопки уже есть на форме)
            btnWorkers.Click += (s, e) => ShowWorkersSection();
            btnProducts.Click += (s, e) => ShowProductsSection();
            btnShipments.Click += (s, e) => ShowShipmentsSection();

            // По умолчанию показываем список работников
            ShowWorkersSection();
        }

        /// <summary>
        /// Очищает панель контента.
        /// </summary>
        private void ClearContent()
        {
            pnlContent.Controls.Clear();
            currentSection = null;
        }

        // ------------------- РАЗДЕЛ "СПИСОК РАБОТНИКОВ" -------------------
        private void ShowWorkersSection()
        {
            ClearContent();
            var dgv = new DataGridView
            {
                Dock = DockStyle.Fill,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                ReadOnly = true,
                RowHeadersVisible = false,
                BackgroundColor = Color.White,
                CellBorderStyle = DataGridViewCellBorderStyle.None
            };
            LoadUsers(dgv);
            pnlContent.Controls.Add(dgv);
            currentSection = dgv;
        }

        private void LoadUsers(DataGridView dgv)
        {
            var users = userService.GetAllUsers();
            dgv.DataSource = users.Select(u => new
            {
                u.Id,
                u.FirstName,
                u.LastName,
                u.MiddleName,
                u.Email,
                u.IsActive,
                Role = u.Role?.Title
            }).ToList();
        }

        // ------------------- РАЗДЕЛ "СПИСОК ТОВАРОВ" -------------------
        private void ShowProductsSection()
        {
            ClearContent();

            // Верхняя панель с кнопками
            var topBar = new Panel { Dock = DockStyle.Top, Height = 50 };
            var btnProduct = new Button { Text = "Товар", Location = new Point(10, 10), Size = new Size(100, 30) };
            var btnCategory = new Button { Text = "Категория", Location = new Point(120, 10), Size = new Size(100, 30) };
            topBar.Controls.Add(btnProduct);
            topBar.Controls.Add(btnCategory);

            // Контекстное меню для кнопки "Товар"
            var productMenu = new ContextMenuStrip();
            productMenu.Items.Add("Добавить", null, (s, e) => AddProduct());
            productMenu.Items.Add("Редактировать", null, (s, e) => EditProduct());
            productMenu.Items.Add("Удалить", null, (s, e) => DeleteProduct());
            btnProduct.Click += (s, e) => productMenu.Show(btnProduct, new Point(0, btnProduct.Height));

            // Кнопка "Категория" открывает форму управления категориями
            btnCategory.Click += (s, e) =>
            {
                using (var form = new FormEditCategory(Guid.Empty, ""))
                {
                    form.ShowDialog();
                    // После закрытия обновляем таблицу товаров (категории могли измениться)
                    LoadProducts(dgvProducts);
                }
            };

            // Таблица товаров
            var dgv = new DataGridView
            {
                Dock = DockStyle.Fill,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                ReadOnly = true,
                RowHeadersVisible = false,
                BackgroundColor = Color.Gray,
                CellBorderStyle = DataGridViewCellBorderStyle.None
            };
            LoadProducts(dgv);

            pnlContent.Controls.Add(topBar);
            pnlContent.Controls.Add(dgv);
            currentSection = dgv;
        }

        private void LoadProducts(DataGridView dgv)
        {
            var products = productService.GetAllProducts();   // используем productService
            dgv.DataSource = products.Select(p => new
            {
                p.Id,
                p.Article,
                p.Name,
                Category = p.Category?.Name,
                p.Unit,
                p.PurchasePrice,
                p.CurrentStock
            }).ToList();
        }

        private void AddProduct()
        {
            using (var form = new FormAddProduct())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    productService.AddProduct(form.CreatedProduct);
                    LoadProducts(currentSection as DataGridView);
                }
            }
        }

        private void EditProduct()
        {
            var dgv = currentSection as DataGridView;
            if (dgv?.CurrentRow == null) return;
            Guid id = (Guid)dgv.CurrentRow.Cells["Id"].Value;
            var product = productService.GetProductById(id);
            using (var form = new FormEditProduct(product))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    productService.UpdateProduct(form.UpdatedProduct);
                    LoadProducts(dgv);
                }
            }
        }

        private void DeleteProduct()
        {
            var dgv = currentSection as DataGridView;
            if (dgv?.CurrentRow == null) return;
            Guid id = (Guid)dgv.CurrentRow.Cells["Id"].Value;
            if (MessageBox.Show("Удалить этот товар?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    productService.DeleteProduct(id);
                    LoadProducts(dgv);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ------------------- РАЗДЕЛ "ИСТОРИЯ ОТГРУЗОК" -------------------
        private void ShowShipmentsSection()
        {
            ClearContent();
            var split = new SplitContainer
            {
                Dock = DockStyle.Fill,
                Orientation = Orientation.Vertical,
                SplitterDistance = (int)(this.ClientSize.Width * 0.6)
            };
            // Левая часть – таблица отгрузок
            var dgvShipments = new DataGridView
            {
                Dock = DockStyle.Fill,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                ReadOnly = true,
                RowHeadersVisible = false,
                BackgroundColor = Color.White,
                CellBorderStyle = DataGridViewCellBorderStyle.None
            };
            // Правая часть – состав выбранной отгрузки
            var dgvItems = new DataGridView
            {
                Dock = DockStyle.Fill,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                ReadOnly = true,
                RowHeadersVisible = false,
                BackgroundColor = Color.White,
                CellBorderStyle = DataGridViewCellBorderStyle.None
            };
            split.Panel1.Controls.Add(dgvShipments);
            split.Panel2.Controls.Add(dgvItems);
            pnlContent.Controls.Add(split);
            currentSection = split;

            LoadShipments(dgvShipments, dgvItems);
            dgvShipments.SelectionChanged += (s, e) =>
            {
                if (dgvShipments.CurrentRow != null)
                {
                    Guid id = (Guid)dgvShipments.CurrentRow.Cells["Id"].Value;
                    LoadShipmentItems(id, dgvItems);
                }
            };
        }

        private void LoadShipments(DataGridView dgvShipments, DataGridView dgvItems)
        {
            var shipments = shipmentService.GetAllShipments();
            dgvShipments.DataSource = shipments.Select(s => new
            {
                s.Id,
                User = s.User?.Email,
                Destination = $"{s.Country}, {s.City}, {s.Street}, {s.Building}",
                s.ShipmentDate
            }).ToList();
            if (dgvShipments.Rows.Count > 0)
            {
                dgvShipments.CurrentCell = dgvShipments.Rows[0].Cells[0];
                LoadShipmentItems((Guid)dgvShipments.Rows[0].Cells["Id"].Value, dgvItems);
            }
        }

        private void LoadShipmentItems(Guid shipmentId, DataGridView dgvItems)
        {
            var shipment = shipmentService.GetAllShipments().FirstOrDefault(s => s.Id == shipmentId);
            dgvItems.DataSource = shipment?.ShipmentItems.Select(i => new
            {
                Product = i.Product?.Name,
                i.Quantity
            }).ToList();
        }

        // ------------------- Освобождение ресурсов -------------------
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            productService.Dispose();
            categoryService.Dispose();
            shipmentService.Dispose();
            base.OnFormClosing(e);
        }
    }
}
