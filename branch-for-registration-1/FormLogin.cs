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
            ValidationHelper.DisableSpaceAndEnter(textBoxEmail);
            ValidationHelper.DisableSpaceAndEnter(textBoxPassword);
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Login"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var email = textBoxEmail.Text.Trim();
            var password = textBoxPassword.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter email and password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address (must contain '@' and a dot).","Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var hash = HashHelper.GetHash(password);
            var role = userService.ValidateUser(email, hash);

            if (role != null)
            {
                MessageBox.Show($"Welcome, {role}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FormMain mainForm = new FormMain(email, role);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid email or password, or account is blocked.","Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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