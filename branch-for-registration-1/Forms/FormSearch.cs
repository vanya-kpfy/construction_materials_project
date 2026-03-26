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

        public FormSearch()
        {
            InitializeComponent();
            categoryService = new CategoryService();
            LoadCategories();

            ValidationHelper.DisableSpaceAndEnter(txtArticle);
            ValidationHelper.DisableSpaceAndEnter(txtName);
        }

        private void LoadCategories()
        {
            var categories = categoryService.GetAllCategories();
            cbCategory.DataSource = categories;
            cbCategory.DisplayMember = "Name";
            cbCategory.ValueMember = "Id";
            cbCategory.SelectedIndex = -1; // ничего не выбрано
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Article = txtArticle.Text.Trim();
            ProductName = txtName.Text.Trim();
            if (cbCategory.SelectedValue != null && cbCategory.SelectedValue is Guid id)
            {
                CategoryId = id;
            }
            else
            {
                CategoryId = null;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            categoryService.Dispose();
            base.OnFormClosing(e);
        }
    }
}