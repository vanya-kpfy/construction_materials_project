using branch_for_registration_1.Classes;
using branch_for_registration_1.DataBase;
using branch_for_registration_1.DTO;
using branch_for_registration_1.HeshSHA256;
using branch_for_registration_1.ValidationTextBox;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
        }

        // Для тестирования
        public WorkingWithUsers(AppDbContext db)
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

            var emailToLower = email.Trim().ToLower();

            return db.Users.Any(u => u.Email == emailToLower);
        }

        /// <summary>
        /// Проверяет введенные данные при входе в аккаунт
        /// </summary>
        /// <param name="email"></param>
        /// <param name="passwordHash"></param>
        /// <returns></returns>
        public User ValidateUser(string email, string password)
        {
            var emailToLower = email.Trim().ToLower();

            var user = db.Users
                .Include(u => u.Role)
                .FirstOrDefault(u =>
                    u.Email == emailToLower &&
                    u.IsActive);

            if (user is null || !HashHelper.VerifyPassword(password, user.PasswordHash))
            {
                return null;
            }

            return user;
        }

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

        private Guid GetDefaultRoleId()
        {
            var role = db.Roles.FirstOrDefault(r => r.Title == "Worker");

            if (role is null)
            {
                throw new Exception("RoleNotFound");
            }

            return role.Id;
        }

        /// <summary>
        /// Метод, который создает пользователя
        /// </summary>
        /// <param name="request"></param>
        /// <exception cref="Exception"></exception>
        public void Register(RegisterRequest request)
        {
            ValidationHelper.ValidateRegisterRequest(request);

            if (EmailExists(request.Email))
            {
                throw new Exception("EmailExists");
            }

            var user = new User
            {
                Id = Guid.NewGuid(),
                FirstName = request.FirstName,
                LastName = request.LastName,
                MiddleName = request.MiddleName,
                Email = request.Email.Trim().ToLower(),
                PasswordHash = HashHelper.GetHash(request.Password),
                RoleId = GetDefaultRoleId(),
                IsActive = true
            };


            db.Users.Add(user);
            db.SaveChanges();
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