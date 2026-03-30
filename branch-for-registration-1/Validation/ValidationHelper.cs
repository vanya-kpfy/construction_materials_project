using branch_for_registration_1.DTO;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace branch_for_registration_1.ValidationTextBox
{
    /// <summary>
    /// Вспомогательный класс для валидации ввода и проверки email
    /// </summary>
    public static class ValidationHelper
    {
        /// <summary>
        /// Запрещаем ввод пробела и Enter.
        /// </summary>
        /// <param name="textBox">Текстовое поле, к которому применяется запрет</param>
        public static void DisableSpaceAndEnter(params TextBox[] textBox)
        {
            foreach (var textBoxIitem in textBox)
            {
                textBoxIitem.KeyPress += TextBox_KeyPress_NoSpaceNoEnter;
            }
        }

        // Обработчик события KeyPress
        private static void TextBox_KeyPress_NoSpaceNoEnter(object sender, KeyPressEventArgs e)
        {
            // 32 = пробел, 13 = Enter
            if (e.KeyChar == 32 || e.KeyChar == 13)
            {
                e.Handled = true; // отменяем ввод
            }
        }

        /// <summary>
        /// Проверяет, является ли строка корректным email-адресом (с помощью регулярного выражения).
        /// </summary>
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return false;
            }

            if (email.Contains("@"))
            {
                string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                return Regex.IsMatch(email, pattern);
            }
            return false;
        }

        /// <summary>
        /// Метод, который проверяет введенные поля при регистрации пользователя
        /// </summary>
        /// <param name="request"></param>
        /// <exception cref="Exception"></exception>
        public static void ValidateRegisterRequest(RegisterRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.FirstName) || string.IsNullOrWhiteSpace(request.LastName) ||
                string.IsNullOrWhiteSpace(request.Email) || string.IsNullOrWhiteSpace(request.Password))
            {
                throw new Exception("FillFieldsForRegister");
            }

            if (!IsValidEmail(request.Email))
            {
                throw new Exception("InvalidEmail");
            }

            if (request.Password.Length < 3)
            {
                throw new Exception("PasswordTooShort");
            }

            if (request.Password != request.ConfirmPassword)
            {
                throw new Exception("PasswordsDoNotMatch");
            }
        }
    }
}