using branch_for_registration_1.Classes;
using branch_for_registration_1.DataBase;
using branch_for_registration_1.DTO;
using branch_for_registration_1.HeshSHA256;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace branch_for_registration_1.UsersServices
{
    /// <summary>
    /// Сервис для работы с пользователями: регистрация, вход, проверка email
    /// </summary>
    public class WorkingWithUsers
    {
        /// <summary>
        /// Проверяет, занят ли указанный email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public async Task<bool> EmailExists(string email)
        {
            using (var db = new AppDbContext())
            {
                if (string.IsNullOrEmpty(email))
                {
                    return false;
                }

                var emailToLower = email.Trim().ToLower();

                return await db.Users.AnyAsync(u => u.Email == emailToLower);
            }
        }

        /// <summary>
        /// Проверяет введенные данные при входе в аккаунт
        /// </summary>
        /// <param name="email"></param>
        /// <param name="passwordHash"></param>
        /// <returns></returns>
        public async Task<User> ValidateUser(string email, string password)
        {
            using (var db = new AppDbContext())
            {
                var emailToLower = email.Trim().ToLower();

                var user = await db.Users
                    .Include(u => u.Role)
                    .FirstOrDefaultAsync(u => u.Email == emailToLower && u.IsActive);

                if (user is null || !HashHelper.VerifyPassword(password, user.PasswordHash))
                {
                    return null;
                }

                return user;
            }
        }

        /// <summary>
        /// Возвращает всех пользователей с их ролями
        /// </summary>
        /// <returns></returns>
        public async Task<List<User>> GetAllUsers()
        {
            using (var db = new AppDbContext())
            {
                return await db.Users.Include(u => u.Role).ToListAsync();
            }
        }

        /// <summary>
        /// Обновляет роль пользователя
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="newRoleId"></param>
        public async Task UpdateUserRole(Guid userId, Guid newRoleId)
        {
            using (var db = new AppDbContext())
            {
                var user = await db.Users.FindAsync(userId);
                if (user != null)
                {
                    user.RoleId = newRoleId;
                    await db.SaveChangesAsync();
                }
            }
        }

        /// <summary>
        /// Активирует или деактивирует учётную запись
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="isActive"></param>
        public async Task SetUserActive(Guid userId, bool isActive)
        {
            using (var db = new AppDbContext())
            {
                var user = await db.Users.FindAsync(userId);
                if (user != null)
                {
                    user.IsActive = isActive;
                    await db.SaveChangesAsync();
                }
            }
        }

        /// <summary>
        /// Возвращает пользователя по email.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public async Task<User> GetUserByEmail(string email)
        {
            using (var db = new AppDbContext())
            {
                return await db.Users.FirstOrDefaultAsync(u => u.Email.ToLower() == email.ToLower());
            }
        }

        /// <summary>
        /// Метод, который создает пользователя
        /// </summary>
        /// <param name="request"></param>
        /// <exception cref="Exception"></exception>
        public async Task Register(RegisterRequest request)
        {
            using (var db = new AppDbContext())
            {
                if (await db.Users.AnyAsync(x => x.Email == request.Email))
                {
                    throw new Exception("EmailExists");
                }

                var roleId = await db.Roles
                    .Where(x => x.Title == "Worker")
                    .Select(x => x.Id)
                    .FirstAsync();

                var user = new User
                {
                    Id = Guid.NewGuid(),
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    MiddleName = request.MiddleName,
                    Email = request.Email.Trim().ToLower(),
                    PasswordHash = HashHelper.GetHash(request.Password),
                    RoleId = roleId,
                    IsActive = true
                };

                db.Users.Add(user);
                await db.SaveChangesAsync();
            }
        }
    }
}