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
                // Добавляем категории, если их ещё нет
                if (!db.Categories.Any())
                {
                    var categories = new List<Category>
                    {
                        new Category { Id = Guid.NewGuid(), Name = "Листовые материалы" },
                        new Category { Id = Guid.NewGuid(), Name = "Сухие смеси и грунтовки" },
                        new Category { Id = Guid.NewGuid(), Name = "Теплоизоляция" },
                        new Category { Id = Guid.NewGuid(), Name = "Блоки для строительства" },
                        new Category { Id = Guid.NewGuid(), Name = "Металлопрокат" },
                        new Category { Id = Guid.NewGuid(), Name = "Кровля" },
                        new Category { Id = Guid.NewGuid(), Name = "Фасадные материалы" },
                        new Category { Id = Guid.NewGuid(), Name = "Профиль для гипсокартона и аксессуары" },
                        new Category { Id = Guid.NewGuid(), Name = "Строительные и расходные материалы" },
                        new Category { Id = Guid.NewGuid(), Name = "Шумоизоляция" },
                        new Category { Id = Guid.NewGuid(), Name = "Ветро-влагозащита и пароизоляция кровли и фасадов" }
                    };
                    db.Categories.AddRange(categories);
                    db.SaveChanges();
                }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }
    }
}