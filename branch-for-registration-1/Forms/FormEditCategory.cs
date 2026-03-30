using branch_for_registration_1.UsersServices;
using branch_for_registration_1.ValidationTextBox;
using System;
using System.Windows.Forms;

namespace branch_for_registration_1.Forms
{
    /// <summary>
    /// Форма для редактирования или удаления категории.
    /// </summary>
    public partial class FormEditCategory : Form
    {
        private CategoryService categoryService = new CategoryService();
        private Guid currentCategoryId;

        /// <summary>
        /// Новое название категории (если было сохранение).
        /// </summary>
        public string NewName { get; private set; }

        public FormEditCategory(Guid empty, string v)
        {
            InitializeComponent();

            LoadCategories();
            // Подписываемся на выбор категории
            cbCategory.SelectedIndexChanged += CbCategory_SelectedIndexChanged;
        }

        /// <summary>
        /// Загружает категории в выпадающий список.
        /// </summary>
        private async void LoadCategories()
        {
            var categories = await categoryService.GetAllCategories();
            cbCategory.DataSource = categories;
            cbCategory.DisplayMember = "Name";
            cbCategory.ValueMember = "Id";
            // Если есть категории, выбираем первую, иначе поля недоступны
            if (cbCategory.Items.Count > 0)
            {
                cbCategory.SelectedIndex = 0;
            }
            else
            {
                txtName.Enabled = false;
                btnSave.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        /// <summary>
        /// Обработчик выбора категории: обновляем текстовое поле.
        /// </summary>
        private void CbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategory.SelectedValue is null)
            {
                return;
            }

            if (Guid.TryParse(cbCategory.SelectedValue.ToString(), out Guid id))
            {
                currentCategoryId = id;
                txtName.Text = cbCategory.Text;
                txtName.Enabled = true;
                btnSave.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                currentCategoryId = Guid.Empty;
            }
        }

        /// <summary>
        /// Сохранить изменения названия категории.
        /// </summary>
        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (currentCategoryId == Guid.Empty)
            {
                MessageBox.Show(LanguageHelper.GetString("SelectCategoryFirst"),LanguageHelper.GetString("Validation"),MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show(LanguageHelper.GetString("CategoryNameRequired"),LanguageHelper.GetString("Validation"),MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                await categoryService.UpdateCategory(currentCategoryId, txtName.Text.Trim());
                NewName = txtName.Text.Trim();
                MessageBox.Show(LanguageHelper.GetString("CategorySaved"),LanguageHelper.GetString("Success"),MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(LanguageHelper.GetString(ex.Message), LanguageHelper.GetString("Error"),MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Удалить выбранную категорию.
        /// </summary>
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (currentCategoryId == Guid.Empty)
            {
                MessageBox.Show(LanguageHelper.GetString("SelectCategoryFirst"),LanguageHelper.GetString("Validation"),MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show(LanguageHelper.GetString("ConfirmDeleteCategory"),LanguageHelper.GetString("Confirmation"),MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    await categoryService.DeleteCategory(currentCategoryId);
                    MessageBox.Show(LanguageHelper.GetString("CategoryDeleted"),LanguageHelper.GetString("Success"),MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // После удаления обновляем список категорий и выбираем первую
                    LoadCategories();
                    if (cbCategory.Items.Count > 0)
                    {
                        cbCategory.SelectedIndex = 0;
                    }
                    else
                    {
                        txtName.Clear();
                        txtName.Enabled = false;
                        btnSave.Enabled = false;
                        btnDelete.Enabled = false;
                    }
                    // Сигнал, что категория удалена – можно обновить список в админке
                    DialogResult = DialogResult.OK;
                    // Не закрываем форму, даём возможность выбрать другую категорию или закрыть
                }
                catch (Exception ex)
                {
                    MessageBox.Show(LanguageHelper.GetString(ex.Message), LanguageHelper.GetString("Error"),MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Кнопка "Отмена" – просто закрывает форму.
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}