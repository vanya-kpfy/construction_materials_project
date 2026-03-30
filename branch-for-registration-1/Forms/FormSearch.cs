using branch_for_registration_1.UsersServices;
using branch_for_registration_1.ValidationTextBox;
using System;
using System.Windows.Forms;

namespace branch_for_registration_1.Forms
{

    /// <summary>
    /// Форма для расширенного поиска товаров (по артикулу, названию, категории)
    /// </summary>
    public partial class FormSearch : Form
    {

        private CategoryService categoryService;
        private ProductService productService;
        /// <summary>
        /// Артикул (часть) для поиска
        /// </summary>
        public string Article { get; private set; }

        /// <summary>
        /// Название (часть) для поиска
        /// </summary>
        public new string ProductName { get; private set; }

        /// <summary>
        /// Идентификатор категории (null – любая)
        /// </summary>
        public Guid? CategoryId { get; private set; }

        public FormSearch(ProductService productService)
        {
            this.productService = productService ?? 
                throw new ArgumentNullException(nameof(productService));
            InitializeComponent();

            categoryService = new CategoryService();
            LoadCategories();

            ValidationHelper.DisableSpaceAndEnter(txtArticle, txtName);
        }
        private async void LoadCategories()
        {
            var categories = await categoryService.GetAllCategories();
            cbCategory.DataSource = categories;
            cbCategory.DisplayMember = "Name";
            cbCategory.ValueMember = "Id";
            cbCategory.SelectedIndex = -1; // ничего не выбрано
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            Article = txtArticle.Text.Trim();
            ProductName = txtName.Text.Trim();
            CategoryId = cbCategory.SelectedValue as Guid?;

            // Выполняем поиск через сервис
            var products = await productService.SearchProductsAdvanced(Article, ProductName, CategoryId);

            // Передаём результаты в главную форму через статическое свойство
            FormMain.LastSearchResults = products;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}