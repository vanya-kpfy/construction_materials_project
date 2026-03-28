using branch_for_registration_1.Classes;
using branch_for_registration_1.UsersServices;
using branch_for_registration_1.ValidationTextBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace branch_for_registration_1.Forms
{
    public partial class FormShipment : Form
    {
        private Guid userId;
        private ProductService productService = new ProductService();
        private ShipmentService shipmentService = new ShipmentService();
        private List<ShipmentItem> cart = new List<ShipmentItem>();

        public FormShipment(Guid currentUserId)
        {
            InitializeComponent();
            this.Text = "Create Shipment";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Size = new System.Drawing.Size(550, 550);

            userId = currentUserId;

            LoadProducts();
            SetupCartGrid();

            // Запрет пробелов и Enter в текстовых полях
            ValidationHelper.DisableSpaceAndEnter(txtCountry, txtCity, txtRegion, txtStreet, txtBuilding);
        }

        private void LoadProducts()
        {
            var products = productService.GetAllProducts();
            cbProduct.DataSource = products;
            cbProduct.DisplayMember = "Name";
            cbProduct.ValueMember = "Id";
        }

        private void SetupCartGrid()
        {
            dgvCart.Columns.Clear();
            dgvCart.Columns.Add("ProductName", "Product");
            dgvCart.Columns.Add("Quantity", "Quantity");
            dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void RefreshCart()
        {
            dgvCart.Rows.Clear();
            foreach (var item in cart)
            {
                dgvCart.Rows.Add(item.Product?.Name, item.Quantity);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbProduct.SelectedItem == null) return;

            var product = cbProduct.SelectedItem as Product;
            int quantity = (int)nudQuantity.Value;

            if (quantity <= 0)
            {
                MessageBox.Show("Quantity must be greater than 0.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (quantity > product.CurrentStock)
            {
                MessageBox.Show($"Not enough stock. Available: {product.CurrentStock}", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var existing = cart.FirstOrDefault(i => i.ProductId == product.Id);
            if (existing != null)
            {
                if (existing.Quantity + quantity > product.CurrentStock)
                {
                    MessageBox.Show($"Total quantity would exceed stock. Available: {product.CurrentStock}", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                existing.Quantity += quantity;
            }
            else
            {
                cart.Add(new ShipmentItem
                {
                    Id = Guid.NewGuid(),
                    ProductId = product.Id,
                    Quantity = quantity,
                    Product = product
                });
            }
            RefreshCart();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvCart.CurrentRow == null) return;
            int idx = dgvCart.CurrentRow.Index;
            cart.RemoveAt(idx);
            RefreshCart();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Проверяем заполнение адреса
            if (string.IsNullOrWhiteSpace(txtCountry.Text) || string.IsNullOrWhiteSpace(txtCity.Text) || string.IsNullOrWhiteSpace(txtStreet.Text) || string.IsNullOrWhiteSpace(txtBuilding.Text))
            {
                MessageBox.Show("Please fill in Country, City, Street and Building.", "Error",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cart.Count == 0)
            {
                MessageBox.Show("Please add at least one product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                shipmentService.CreateShipment(
                    userId,
                    txtCountry.Text.Trim(),
                    txtCity.Text.Trim(),
                    txtRegion.Text.Trim(),
                    txtStreet.Text.Trim(),
                    txtBuilding.Text.Trim(),
                    cart
                );
                MessageBox.Show("Shipment created successfully!", "Success",MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            productService.Dispose();
            shipmentService.Dispose();
            base.OnFormClosing(e);
        }
    }
}