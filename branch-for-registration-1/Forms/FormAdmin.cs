using branch_for_registration_1.UsersServices;
using branch_for_registration_1.ValidationTextBox;
using System;
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
        }

        private async void LoadUsers(DataGridView dgv)
        {
            var users = await userService.GetAllUsers();
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

            var topPanel = new Panel();
            topPanel.Dock = DockStyle.Top;
            topPanel.Height = 50;

            var btnProduct = new Button();
            btnProduct.Text = LanguageHelper.GetString("Product");
            btnProduct.Location = new Point(10, 10);
            btnProduct.Size = new Size(100, 30);

            var btnCategory = new Button();
            btnCategory.Text = LanguageHelper.GetString("Category");
            btnCategory.Location = new Point(120, 10);
            btnCategory.Size = new Size(100, 30);

            topPanel.Controls.Add(btnProduct);
            topPanel.Controls.Add(btnCategory);

            dgvProducts = new DataGridView();
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;

            LoadProducts(dgvProducts);

            pnlContent.Controls.Add(dgvProducts);
            pnlContent.Controls.Add(topPanel);

            var menu = new ContextMenuStrip();
            menu.Items.Add(LanguageHelper.GetString("Add"), null, (s, e) => AddProduct());
            menu.Items.Add(LanguageHelper.GetString("Edit"), null, (s, e) => EditProduct());
            menu.Items.Add(LanguageHelper.GetString("Delete"), null, (s, e) => DeleteProduct());

            btnProduct.Click += (s, e) =>
            {
                menu.Show(btnProduct, new Point(0, btnProduct.Height));
            };

            // Категория
            btnCategory.Click += (s, e) =>
            {
                using (var form = new FormEditCategory(Guid.Empty, ""))
                {
                    form.ShowDialog();
                    LoadProducts(dgvProducts);
                }
            };
        }

        private async void LoadProducts(DataGridView dgv)
        {
            dgv.Columns.Clear();
            dgv.Rows.Clear();
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.Columns.Add("Id", "Id");
            dgv.Columns["Id"].Visible = false;

            dgv.Columns.Add("Article", LanguageHelper.GetString("Article"));
            dgv.Columns.Add("Name", LanguageHelper.GetString("Name"));
            dgv.Columns.Add("Category", LanguageHelper.GetString("Category"));
            dgv.Columns.Add("Unit", LanguageHelper.GetString("Unit"));
            dgv.Columns.Add("Price", LanguageHelper.GetString("Price"));
            dgv.Columns.Add("Stock", LanguageHelper.GetString("Stock"));

            var products = await productService.GetProducts();

            foreach (var p in products)
            {
                dgv.Rows.Add(
                    p.Id,
                    p.Article,
                    p.Name,
                    p.CategoryName,
                    p.Unit,
                    p.PurchasePrice,
                    p.CurrentStock
                );
            }
        }

        private async void AddProduct()
        {
            using (var form = new FormAddProduct())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    await productService.CreateProduct(form.CreatedProduct);
                    LoadProducts(dgvProducts);
                }
            }
        }

        private async void EditProduct()
        {
            var dgv = dgvProducts;
            if (dgv.CurrentRow == null) return;

            Guid id = (Guid)dgv.CurrentRow.Cells["Id"].Value;

            var product = await productService.GetProductById(id);

            using (var form = new FormEditProduct(product))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    await productService.UpdateProduct(form.UpdatedProduct);
                    LoadProducts(dgv);
                }
            }
        }

        private async void DeleteProduct()
        {
            var dgv = dgvProducts;
            if (dgv.CurrentRow == null) return;

            Guid id = (Guid)dgv.CurrentRow.Cells["Id"].Value;

            if (MessageBox.Show(LanguageHelper.GetString("ConfirmDeleteProduct"), LanguageHelper.GetString("Confirm"), MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    await productService.DeleteProduct(id);
                    LoadProducts(dgv);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, LanguageHelper.GetString("Issue"), MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private async void LoadShipments(DataGridView dgvShipments, DataGridView dgvItems)
        {
            var shipments = await shipmentService.GetAllShipments();

            dgvShipments.DataSource = shipments.Select(s => new
            {
                s.Id,
                User = s.User?.Email,
                Destination = s.Address?.FullAddress,
                s.ShipmentDate
            }).ToList();

            dgvShipments.Columns["Id"].HeaderText = "Id";
            dgvShipments.Columns["User"].HeaderText = LanguageHelper.GetString("User");
            dgvShipments.Columns["Destination"].HeaderText = LanguageHelper.GetString("Address");
            dgvShipments.Columns["ShipmentDate"].HeaderText = LanguageHelper.GetString("Date");

            dgvShipments.SelectionChanged += (s, e) =>
            {
                if (dgvShipments.CurrentRow == null)
                {
                    MessageBox.Show(LanguageHelper.GetString("UnknownIssue"));
                    return;
                }

                Guid id = (Guid)dgvShipments.CurrentRow.Cells["Id"].Value;

                var shipment = shipments.FirstOrDefault(x => x.Id == id);

                dgvItems.DataSource = shipment?.ShipmentItems.Select(i => new
                {
                    Product = i.Product?.Name,
                    i.Quantity
                }).ToList();

                dgvItems.Columns["Product"].HeaderText = LanguageHelper.GetString("Product");
                dgvItems.Columns["Quantity"].HeaderText = LanguageHelper.GetString("Quantity");
            };
        }

        private async void LoadShipmentItems(Guid shipmentId, DataGridView dgvItems)
        {
            try
            {
                var shipmentListAsync = await shipmentService.GetAllShipments();
                var shipment = shipmentListAsync.FirstOrDefault(s => s.Id == shipmentId);

                dgvItems.DataSource = shipment?.ShipmentItems.Select(i => new
                {
                    Product = i.Product?.Name,
                    i.Quantity
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(LanguageHelper.GetString(ex.Message));
            }
        }

        // ------------------- Освобождение ресурсов -------------------
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
        }
    }
}
