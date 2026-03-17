using System;

namespace branch_for_registration_1.Classes
{
    /// <summary>
    /// Класс User представляет пользователя системы
    /// </summary>
    public class User
    {
        /// <summary>
        /// Уникальный идентификатор пользователя (GUID)
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Фамилия пользователя
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Отчество пользователя (может быть пустым)
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// Электронная почта (используется как логин)
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Хеш пароля (SHA256)
        /// </summary>
        public string PasswordHash { get; set; }

        /// <summary>
        /// Идентификатор роли пользователя (внешний ключ к таблице Roles)
        /// </summary>
        public Guid RoleId { get; set; }

        /// <summary>
        /// Флаг активности учётной записи (true – активна, false – заблокирована)
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Для доступа к объекту роли
        /// </summary>
        public Role Role { get; set; }
    }
}