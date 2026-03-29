using System;

namespace branch_for_registration_1.DTO
{
    /// <summary>
    /// Класс, который содержит данные о пользователе при регистрации
    /// </summary>
    public class RegisterRequest
    {
        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Фамилия пользователя
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Отчество пользователя
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// Электронная почта пользователя
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Пароль пользователя
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Пароль пользователя, введенный второй раз для проверки на совпадение
        /// </summary>
        public string ConfirmPassword { get; set; }
    }
}
