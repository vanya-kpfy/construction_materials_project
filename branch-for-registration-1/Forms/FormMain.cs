using System;
using System.Windows.Forms;

namespace branch_for_registration_1.Forms
{
    /// <summary>
    /// Главная форма (пока заглушка)
    /// </summary>
    public partial class FormMain : Form
    {
        public FormMain(string email, string role)
        {
            InitializeComponent();
            // Можно просто показать приветствие
            MessageBox.Show($"Welcome, {email}! You are logged in as {role}.", "Main");
        }
    }
}
