using branch_for_registration_1.Classes;
using branch_for_registration_1.DataBase;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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
        }

<<<<<<< HEAD
        /// <summary>
        /// Для тестирования
        /// </summary>
        /// <param name="dbContext"></param>
        public WorkingWithUsers(AppDbContext dbContext)
=======
        // Для тестирования
        public WorkingWithUsers(AppDbContext db)
>>>>>>> 50a9d84cf56fe235c81484434719075b5e1ac49a
        {
            this.db = db;
        }

        /// <summary>
        /// Проверяет, занят ли указанный email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool EmailExists(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return false;
            }
            try
            {
                // Приводим к нижнему регистру для сравнения без учёта регистра
                return db.Users.Any(u => u.Email.ToLower() == email.ToLower());
            }
            catch (Exception ex)
            {
                // Логируем ошибку или показываем сообщение
                Console.WriteLine($"Error in EmailExists: {ex.Message}");
                return false;
            }
        }

        public Role GetOrCreateWorkerRole()
        {
            // Ищем роль Worker в базе
            var workerRole = db.Roles.FirstOrDefault(r => r.Title == "Worker"); ;

            // Если роли Worker нет, создаём их
            if (workerRole == null)
            {
                // Создаём новую роль
                Role newRole = new Role { Id = Guid.NewGuid(), Title = "Worker" };
                db.Roles.Add(newRole);
                db.SaveChanges(); // сохраняем отдельно

                // Получаем созданную роль
                workerRole = db.Roles.First(r => r.Title == "Worker");
            }
            return workerRole;
        }

        /// <summary>
        /// Добавляет нового пользователя с ролью Worker
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="middleName"></param>
        /// <param name="email"></param>
        /// <param name="passwordHash"></param>
        public void AddUser(string firstName, string lastName, string middleName, string email, string passwordHash)
        {
            var workerRole = GetOrCreateWorkerRole();

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
        /// <param name="email"></param>
        /// <param name="passwordHash"></param>
        /// <returns></returns>
        public string ValidateUser(string email, string passwordHash)
        {
            var user = db.Users.Include(u => u.Role)
                .FirstOrDefault(u =>
                    u.Email.ToLower() == email.ToLower() &&
                    u.PasswordHash == passwordHash &&
                    u.IsActive);

            if (user == null || user.Role == null)
            {
                return null;
            }

            return user.Role?.Title;
        }

        public string ValidateUserExplicit(string email, string passwordHash)
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
<<<<<<< HEAD

        /// <summary>
        /// Возвращает всех пользователей с их ролями
        /// </summary>
        /// <returns></returns>
        public List<User> GetAllUsers()
        {
            return db.Users.Include(u => u.Role).ToList();
        }

        /// <summary>
        /// Обновляет роль пользователя
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="newRoleId"></param>
        public void UpdateUserRole(Guid userId, Guid newRoleId)
        {
            var user = db.Users.Find(userId);
            if (user != null)
            {
                user.RoleId = newRoleId;
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Активирует или деактивирует учётную запись
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="isActive"></param>
        public void SetUserActive(Guid userId, bool isActive)
        {
            var user = db.Users.Find(userId);
            if (user != null)
            {
                user.IsActive = isActive;
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Возвращает пользователя по email.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public User GetUserByEmail(string email)
        {
            return db.Users.FirstOrDefault(u => u.Email.ToLower() == email.ToLower());
        }

=======
        
>>>>>>> 50a9d84cf56fe235c81484434719075b5e1ac49a
        /// <summary>
        /// Освобождает ресурсы контекста базы данных (без этого метода компилятор выдает ошибку, что не осуществлен метод Dispose, поэтому написал)
        /// </summary>
        public void Dispose()
        {
            db.Dispose();
        }
    }
}