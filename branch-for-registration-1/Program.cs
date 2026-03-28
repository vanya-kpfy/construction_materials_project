using branch_for_registration_1.Classes;
using branch_for_registration_1.DataBase;
using branch_for_registration_1.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace branch_for_registration_1
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // Инициализация БД
            using (AppDbContext db = new AppDbContext())
            {
                
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }
    }
}