using System;
using System.Windows.Forms;

namespace branch_for_registration_1.Forms
{
    public partial class FormMain : Form
    {
        private string userRole;

        public FormMain(string role)
        {
            InitializeComponent();
            userRole = role;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
