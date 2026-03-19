using System;
using branch_for_registration_1.Classes;
using branch_for_registration_1.DataBase;
using System.Linq;

namespace branch_for_registration_1.UsersServices
{
    /// <summary>
    /// Сервис для работы с пользователями: регистрация, вход, проверка email
    /// </summary>
    public class WorkingWithUsers : IDisposable
    {
        private AppDbContext db;

        /// <summary>
        /// Конструктор – создаёт подключение к базе данных
        /// </summary>
        public WorkingWithUsers()
        {
            db = new AppDbContext();
            db.EnsureDatabaseCreated();
        }

        // Для тестирования
        public WorkingWithUsers(AppDbContext dbContext)
        {
            db = dbContext;
        }

        /// <summary>
        /// Проверяет, занят ли указанный email
        /// </summary>
        public bool EmailExists(string email)
        {
            // Используем LINQ (метод Any)
            return db.Users.Any(u => u.Email.ToLower() == email.ToLower());
        }

        /// <summary>
        /// Добавляет нового пользователя с ролью Worker
        /// </summary>
        public void AddUser(string firstName, string lastName, string middleName, string email, string passwordHash)
        {
            // Ищем роль Worker в базе
            Role workerRole = db.Roles.FirstOrDefault(r => r.Title == "Worker");

            // Если роли Worker нет, создаём их
            if (workerRole == null)
            {
                db.Roles.AddRange(new Role { Id = Guid.NewGuid(), Title = "Worker" });
                db.SaveChanges();
                workerRole = db.Roles.First(r => r.Title == "Worker");
            }

            // Создаём объект нового пользователя
            User newUser = new User
            {
                Id = Guid.NewGuid(),
                FirstName = firstName,
                LastName = lastName,
                MiddleName = string.IsNullOrEmpty(middleName) ? null : middleName,
                Email = email,
                PasswordHash = passwordHash,
                RoleId = workerRole.Id,
                IsActive = true
            };
            // Добавляем в таблицу и сохраняем
            db.Users.Add(newUser);
            db.SaveChanges();
        }

        /// <summary>
        /// Проверяет логин пользователя и возвращает его роль
        /// </summary>
        public string ValidateUser(string email, string passwordHash)
        {
            // Ищем пользователя с подходящими данными и загружаем его роль
            User user = db.Users.Where(u => u.Email.ToLower() == email.ToLower() && u.PasswordHash == passwordHash && u.IsActive).FirstOrDefault();
            if (user == null)
            {  
                return null; 
            }
            // Явно загружаем связанную роль
            db.Entry(user).Reference(u => u.Role).Load();
            return user.Role?.Title;
        }
        /// <summary>
        /// Освобождает ресурсы контекста базы данных (без этого метода компилятор выдает ошибку, что не осуществлен метод Dispose, поэтому написал)
        /// </summary>
        public void Dispose()
        {
            db.Dispose();
        }
    }
}