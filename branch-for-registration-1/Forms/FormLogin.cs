using branch_for_registration_1.HeshSHA256;
using branch_for_registration_1.UsersServices;
using branch_for_registration_1.ValidationTextBox;
using System;
using System.Windows.Forms;

namespace branch_for_registration_1.Forms
{
    /// <summary>
    /// Форма входа в систему
    /// </summary>
    public partial class FormLogin : Form
    {
        private WorkingWithUsers userService;

        /// <summary>
        /// Конструктор формы входа
        /// </summary>
        public FormLogin()
        {
            InitializeComponent();
            userService = new WorkingWithUsers();

            // Применяем запрет пробелов и Enter ко всем текстовым полям
            ValidationHelper.DisableSpaceAndEnter(textBoxEmail, textBoxPassword);
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Login"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var email = textBoxEmail.Text;
            var password = textBoxPassword.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show(LanguageHelper.GetString("FillFieldsForAuth"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidationHelper.IsValidEmail(email))
            {
                MessageBox.Show(LanguageHelper.GetString("InvalidEmail"),"Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var user = userService.ValidateUser(email, password);

            if (user != null)
            {
                MessageBox.Show(string.Format(LanguageHelper.GetString("LoginSuccess"), user.Role.Title), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var mainForm = new FormMain(user);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(LanguageHelper.GetString("LoginFailed"),"Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// /Обработчик кнопки "Register" – открывает форму регистрации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            var regForm = new FormRegister();
            regForm.ShowDialog(); // после закрытия возвращаемся сюда
        }

        /// <summary>
        /// Освобождение ресурсов при закрытии формы
        /// </summary>
        /// <param name="e"></param>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
        }
    }
}