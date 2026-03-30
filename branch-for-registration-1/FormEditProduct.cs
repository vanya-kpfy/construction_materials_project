using branch_for_registration_1.Classes;
using branch_for_registration_1.UsersServices;
using branch_for_registration_1.ValidationTextBox;
using System;
using System.Windows.Forms;

namespace branch_for_registration_1.Forms
{
    /// <summary>
    /// Форма для редактирования товара
    /// </summary>
    public partial class FormEditProduct : Form
    {
        private ProductService productService = new ProductService();
        private CategoryService categoryService = new CategoryService();
        private Product originalProduct;

        /// <summary>
        /// Обновлённый товар (доступен после успешного закрытия)
        /// </summary>
        public Product UpdatedProduct { get; private set; }

        /// <summary>
        /// Конструктор формы редактирования.
        /// </summary>
        /// <param name="product">Редактируемый товар.</param>
        public FormEditProduct(Product product)
        {
            InitializeComponent();
            originalProduct = product;
            UpdatedProduct = new Product(); // создаём копию

            LoadCategories();
            LoadData();
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
        /// Заполняет поля формы данными редактируемого товара
        /// </summary>
        private void LoadData()
        {
            txtName.Text = originalProduct.Name;
            txtArticle.Text = originalProduct.Article;
            txtUnit.Text = originalProduct.Unit;
            nudPrice.Value = originalProduct.PurchasePrice;
            if (originalProduct.CategoryId != Guid.Empty)
            {
                cbCategory.SelectedValue = originalProduct.CategoryId;
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Сохранить"
        /// </summary>
        private void btnOKE_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtArticle.Text))
            {
                MessageBox.Show(LanguageHelper.GetString("NameArticleRequired"),LanguageHelper.GetString("Validation"),MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UpdatedProduct.Id = originalProduct.Id;
            UpdatedProduct.Name = txtName.Text.Trim();
            UpdatedProduct.Article = txtArticle.Text.Trim();
            UpdatedProduct.Unit = txtUnit.Text.Trim();
            UpdatedProduct.PurchasePrice = nudPrice.Value;
            UpdatedProduct.CategoryId = cbCategory.SelectedValue != null? (Guid)cbCategory.SelectedValue : Guid.Empty;

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