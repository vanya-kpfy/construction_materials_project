using branch_for_registration_1.Classes;
using branch_for_registration_1.DTO;
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
        private List<CartItemDto> cart = new List<CartItemDto>();

        public FormShipment(Guid currentUserId)
        {
            InitializeComponent();
            this.Text = LanguageHelper.GetString("CreateShipment");
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
            var products = productService.GetProducts();

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
                dgvCart.Rows.Add(item.ProductName, item.Quantity);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbProduct.SelectedItem == null) return;

            var product = cbProduct.SelectedItem as ProductDto;

            if (product is null)
            {
                MessageBox.Show(LanguageHelper.GetString("ProductNotFound"));
                return;
            }
            int quantity = (int)nudQuantity.Value;

            if (quantity <= 0)
            {
                MessageBox.Show(LanguageHelper.GetString("QuantityZero"));
                return;
            }

            if (quantity > product.CurrentStock)
            {
                MessageBox.Show(string.Format(LanguageHelper.GetString("NotEnoughStock"), product.CurrentStock));
                return;
            }

            var existing = cart.FirstOrDefault(i => i.ProductId == product.Id);

            if (existing != null)
            {
                if (existing.Quantity + quantity > product.CurrentStock)
                {
                    MessageBox.Show(string.Format(LanguageHelper.GetString("TotalExceedsStock"), product.CurrentStock));
                    return;
                }

                existing.Quantity += quantity;
            }
            else
            {
                cart.Add(new CartItemDto
                {
                    ProductId = product.Id,
                    ProductName = product.Name,
                    Quantity = quantity,
                    Stock = product.CurrentStock
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
            if (string.IsNullOrWhiteSpace(txtCountry.Text) ||
                string.IsNullOrWhiteSpace(txtCity.Text) ||
                string.IsNullOrWhiteSpace(txtStreet.Text) ||
                string.IsNullOrWhiteSpace(txtBuilding.Text))
            {
                MessageBox.Show(LanguageHelper.GetString("RequiredFields"));
                return;
            }

            if (cart.Count == 0)
            {
                MessageBox.Show(LanguageHelper.GetString("NoProducts"));
                return;
            }

            try
            {
                var shipmentItems = cart.Select(c => new ShipmentItem
                {
                    Id = Guid.NewGuid(),
                    ProductId = c.ProductId,
                    Quantity = c.Quantity
                }).ToList();

                shipmentService.CreateShipment(
                    userId,
                    txtCountry.Text.Trim(),
                    txtCity.Text.Trim(),
                    txtRegion.Text.Trim(),
                    txtStreet.Text.Trim(),
                    txtBuilding.Text.Trim(),
                    shipmentItems
                );

                MessageBox.Show(LanguageHelper.GetString("ShipmentCreated"));
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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