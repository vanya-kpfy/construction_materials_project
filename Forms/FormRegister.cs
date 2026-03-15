using branch_for_registration_1.HeshSHA256;
using branch_for_registration_1.UsersServices;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace branch_for_registration_1.Forms
{
    public partial class FormRegister : Form
    {
        private WorkingWithUsers userService;

        // Закругление для Button
        private void MakeButtonRounded(Button button, int radius)
        {
            button.Paint += (sender, e) =>
            {
                Button btn = sender as Button;
                if (btn == null) return;

                System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
                int r = radius * 2;
                Rectangle rect = new Rectangle(0, 0, btn.Width, btn.Height);

                path.AddArc(rect.X, rect.Y, r, r, 180, 90);
                path.AddArc(rect.Right - r, rect.Y, r, r, 270, 90);
                path.AddArc(rect.Right - r, rect.Bottom - r, r, r, 0, 90);
                path.AddArc(rect.X, rect.Bottom - r, r, r, 90, 90);
                path.CloseFigure();

                btn.Region = new System.Drawing.Region(path);
            };

            button.Invalidate();
        }

        // Закругление для TextBox
        private void MakeTextBoxRounded(TextBox textBox, int radius)
        {
            textBox.Paint += (s, e) =>
            {
                TextBox txt = s as TextBox;
                if (txt == null) return;

                var path = new System.Drawing.Drawing2D.GraphicsPath();
                int r = radius * 2;
                var rect = new System.Drawing.Rectangle(0, 0, txt.Width - 1, txt.Height - 1);

                path.AddArc(rect.X, rect.Y, r, r, 180, 90);
                path.AddArc(rect.Right - r, rect.Y, r, r, 270, 90);
                path.AddArc(rect.Right - r, rect.Bottom - r, r, r, 0, 90);
                path.AddArc(rect.X, rect.Bottom - r, r, r, 90, 90);
                path.CloseFigure();

                txt.Region = new System.Drawing.Region(path);
            };
            textBox.Invalidate();
        }
        private void RoundedTextBox(TextBox originalTextBox, int radius)
        {
            // Запоминаем данные
            Point loc = originalTextBox.Location;
            Size size = originalTextBox.Size;
            string text = originalTextBox.Text;
            Font font = originalTextBox.Font;
            string name = originalTextBox.Name;
            int tabIndex = originalTextBox.TabIndex; // запоминаем TabIndex

            // Удаляем старый
            this.Controls.Remove(originalTextBox);

            // Панель
            Panel panel = new Panel();
            panel.Location = loc;
            panel.Size = size;
            panel.BackColor = Color.White;
            panel.TabStop = false; // ОТКЛЮЧАЕМ TabStop у панели, чтобы она не перехватывала фокус

            // Делаем панель круглой
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int r = radius * 2;
            Rectangle rect = new Rectangle(0, 0, panel.Width - 1, panel.Height - 1);

            path.AddArc(rect.X, rect.Y, r, r, 180, 90);
            path.AddArc(rect.Right - r, rect.Y, r, r, 270, 90);
            path.AddArc(rect.Right - r, rect.Bottom - r, r, r, 0, 90);
            path.AddArc(rect.X, rect.Bottom - r, r, r, 90, 90);
            path.CloseFigure();
            panel.Region = new Region(path);

            // Новый TextBox
            TextBox newBox = new TextBox();
            newBox.BorderStyle = BorderStyle.None;
            newBox.Location = new Point(5, 5);
            newBox.Size = new Size(panel.Width - 10, panel.Height - 10);
            newBox.Font = font;
            newBox.Text = text;
            newBox.Name = name;
            newBox.TabIndex = tabIndex; // ВАЖНО: ставим тот же TabIndex
            newBox.TabStop = true; // убеждаемся, что TabStop включён

            // Если это поле пароля
            if (name == "textBoxPassword")
            {
                newBox.PasswordChar = '*';
            }

            // Добавляем TextBox на панель
            panel.Controls.Add(newBox);

            // Добавляем панель на форму
            this.Controls.Add(panel);

            // Обновляем ссылку
            if (name == "textBoxEmail")
                textBoxEmail = newBox;
            else if (name == "textBoxPassword")
                textBoxPassword = newBox;
        }

        public FormRegister()
        {
            InitializeComponent();
            userService = new WorkingWithUsers();
            MakeButtonRounded(buttonRegister, 17);
            MakeButtonRounded(buttonRegisrationINAuth, 17);
            MakeTextBoxRounded(textBoxEmail, 10);
            MakeTextBoxRounded(textBoxPassword, 10);
            RoundedTextBox(textBoxFirstName, 10);
            RoundedTextBox(textBoxLastName, 10);
            RoundedTextBox(textBoxMiddleName, 10);
            RoundedTextBox(textBoxEmail, 10);
            RoundedTextBox(textBoxPassword, 10);
            RoundedTextBox(textBoxConfirmPassword, 10);
        }

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
                MessageBox.Show("Заполните имя, фамилию, email и пароль!","Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirm)
            {
                MessageBox.Show("Пароли не совпадают!","Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password.Length < 3)
            {
                MessageBox.Show("Пароль слишком короткий (минимум 3 символа)","Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверяем email через сервис
            if (userService.EmailExists(email))
            {
                MessageBox.Show("Такой email уже зарегистрирован!","Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var hash = HashHelper.GetHash(password);
            userService.AddUser(firstName, lastName, middleName, email, hash);

            MessageBox.Show("Регистрация успешна! Теперь можете войти.","Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            userService.Dispose();
            base.OnFormClosing(e);
        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMiddleName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelTextVisualFirstName_Click(object sender, EventArgs e)
        {

        }

        private void labelTextVisualLastName_Click(object sender, EventArgs e)
        {

        }

        private void labelTextVisualEmailTwo_Click(object sender, EventArgs e)
        {

        }

        private void buttonRegisrationINAuth_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}