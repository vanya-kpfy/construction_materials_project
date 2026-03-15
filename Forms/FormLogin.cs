using branch_for_registration_1.HeshSHA256;
using branch_for_registration_1.UsersServices;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace branch_for_registration_1.Forms
{
    public partial class FormLogin : Form
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

                btn.Region = new Region(path);
            };

            button.Invalidate();
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
        public FormLogin()
        {
            InitializeComponent();
            userService = new WorkingWithUsers();

            // Запоминаем исходные TabIndex
            int emailTabIndex = textBoxEmail.TabIndex;
            int passwordTabIndex = textBoxPassword.TabIndex;
            int loginTabIndex = buttonLogin.TabIndex;
            int registerTabIndex = buttonRegister.TabIndex;

            MakeButtonRounded(buttonLogin, 17);
            MakeButtonRounded(buttonRegister, 17);
            RoundedTextBox(textBoxEmail, 10);
            RoundedTextBox(textBoxPassword, 10);

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var email = textBoxEmail.Text.Trim();
            var password = textBoxPassword.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите email и пароль!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var hash = HashHelper.GetHash(password);
            var role = userService.ValidateUser(email, hash);

            if (role != null)
            {
                MessageBox.Show($"Привет, {role}!", "Успех",MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormMain mainForm = new FormMain(role);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль, или доступ заблокирован.","Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            FormRegister regForm = new FormRegister();
            regForm.ShowDialog();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            userService.Dispose();
            base.OnFormClosing(e);
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
