using branch_for_registration_1.Classes;
using branch_for_registration_1.UsersServices;
using branch_for_registration_1.ValidationTextBox;
using System;
using System.Windows.Forms;

namespace branch_for_registration_1.Forms
{
    /// <summary>
    /// Форма для добавления нового товара.
    /// </summary>
    public partial class FormAddProduct : Form
    {
        private ProductService productService = new ProductService();
        private CategoryService categoryService = new CategoryService();

        /// <summary>
        /// Созданный товар (доступен после успешного закрытия)
        /// </summary>
        public Product CreatedProduct { get; private set; }

        public FormAddProduct()
        {
            InitializeComponent();
            LoadCategories();
        }

        /// <summary>
        /// Загружает категории в выпадающий список
        /// </summary>
        private void LoadCategories()
        {
            var categories = categoryService.GetAllCategories();
            cbCategory.DataSource = categories;
            cbCategory.DisplayMember = "Name";
            cbCategory.ValueMember = "Id";
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Добавить"
        /// </summary>
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtArticle.Text))
            {
                MessageBox.Show(LanguageHelper.GetString("NameArticleRequired"),LanguageHelper.GetString("Validation"),MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CreatedProduct = new Product
            {
                Id = Guid.NewGuid(),
                Name = txtName.Text.Trim(),
                Article = txtArticle.Text.Trim(),
                Unit = txtUnit.Text.Trim(),
                PurchasePrice = nudPrice.Value,
                CategoryId = cbCategory.SelectedValue != null ? (Guid)cbCategory.SelectedValue : Guid.Empty
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Отмена"
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
