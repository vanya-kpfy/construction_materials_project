using branch_for_registration_1.DTO;
using branch_for_registration_1.UsersServices;
using branch_for_registration_1.ValidationTextBox;
using System;
using System.Windows.Forms;

namespace branch_for_registration_1.Forms
{
    /// <summary>
    /// Форма регистрации нового пользователя
    /// </summary>
    public partial class FormRegister : Form
    {
        private WorkingWithUsers userService;

        /// <summary>
        /// Конструктор формы регистрации
        /// </summary>
        public FormRegister()
        {
            InitializeComponent();
            userService = new WorkingWithUsers();

            // Запрет пробелов и Enter на всех текстовых полях
            ValidationHelper.DisableSpaceAndEnter(textBoxFirstName, textBoxLastName, textBoxMiddleName, textBoxEmail, textBoxPassword, textBoxConfirmPassword);
        }

        /// <summary>
        /// Обработчик кнопки регистрации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void buttonRegister_Click(object sender, EventArgs e)
        {
            var request = new RegisterRequest
            {
                FirstName = textBoxFirstName.Text.Trim(),
                LastName = textBoxLastName.Text.Trim(),
                MiddleName = textBoxMiddleName.Text.Trim(),
                Email = textBoxEmail.Text.Trim(),
                Password = textBoxPassword.Text,
                ConfirmPassword = textBoxConfirmPassword.Text
            };

            try
            {
                await userService.Register(request);

                MessageBox.Show(LanguageHelper.GetString("Success"));
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(LanguageHelper.GetString(ex.Message));
            }
        }

        /// <summary>
        /// Обработчик кнопки "Already have an account? Login" – возврат к форме входа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGoToLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Обработчик кнопки "Cancel"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Освобождение ресурсов
        /// </summary>
        /// <param name="e"></param>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
        }

        private void buttonRegisrationINAuth_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}