using System;

namespace branch_for_registration_1.Classes
{
    // Таблица Users (пользователи)
    public class User
    {
        public Guid Id { get; set; }           // первичный ключ
        public string FirstName { get; set; } // имя
        public string LastName { get; set; }  // фамилия
        public string MiddleName { get; set; } // отчество (может быть пустым)
        public string Email { get; set; }      // электронная почта
        public string PasswordHash { get; set; } // хеш пароля
        public Guid RoleId { get; set; }        // внешний ключ к таблице Roles
        public bool IsActive { get; set; }     // активна ли учётная запись
        public Role Role { get; set; }         // навигационное свойство
    }
}