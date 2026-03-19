using branch_for_registration_1.HeshSHA256;
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
            ValidationHelper.DisableSpaceAndEnter(textBoxFirstName);
            ValidationHelper.DisableSpaceAndEnter(textBoxLastName);
            ValidationHelper.DisableSpaceAndEnter(textBoxMiddleName);
            ValidationHelper.DisableSpaceAndEnter(textBoxEmail);
            ValidationHelper.DisableSpaceAndEnter(textBoxPassword);
            ValidationHelper.DisableSpaceAndEnter(textBoxConfirmPassword);
        }

        /// <summary>
        /// Обработчик кнопки регистрации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            var firstName = textBoxFirstName.Text.Trim();
            var lastName = textBoxLastName.Text.Trim();
            var middleName = textBoxMiddleName.Text.Trim();
            var email = textBoxEmail.Text.Trim();
            var password = textBoxPassword.Text;
            var confirm = textBoxConfirmPassword.Text;

            // Проверки
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in first name, last name, email and password!","Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address (must contain '@' and a dot).","Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirm)
            {
                MessageBox.Show("Passwords do not match!","Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password.Length < 3)
            {
                MessageBox.Show("Password is too short (minimum 3 characters)","Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверка уникальности email
            if (userService.EmailExists(email))
            {
                MessageBox.Show("This email is already registered!","Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var hash = HashHelper.GetHash(password);
            userService.AddUser(firstName, lastName, middleName, email, hash);

            MessageBox.Show("Registration successful! You can now log in.","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
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
            userService.Dispose();
            base.OnFormClosing(e);
        }
        /// <summary>
        /// Выход на форму авторизации (закрываем форму регистрации)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRegisrationINAuth_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}