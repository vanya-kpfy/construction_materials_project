using branch_for_registration_1.Classes;
using branch_for_registration_1.DataBase;
using branch_for_registration_1.Forms;
using System;
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
                db.EnsureDatabaseCreated();

                // Проверяем, есть ли роли
                var rolesQuery = from r in db.Roles select r;
                if (!rolesQuery.Any())
                {
                    // Добавляем роли
                    db.Roles.AddRange(
                        new Role { Title = "Admin" },
                        new Role { Title = "Worker" }
                    );
                    db.SaveChanges();
                }
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }
    }
}