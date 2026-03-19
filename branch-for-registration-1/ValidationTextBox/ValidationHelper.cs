using System;
using System.Linq;
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
        /// <param name="textBox"></param>
        public static void DisableSpaceAndEnter(TextBox textBox)
        {
            textBox.KeyPress += TextBox_KeyPress_NoSpaceNoEnter;
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
        /// Проверяет, является ли строка корректным email-адресом.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return false;
            }
            // Должна быть одна '@'
            var atIndex = email.IndexOf('@');
            if (atIndex <= 0 || atIndex != email.LastIndexOf('@'))
            {
                return false;
            }
            // Локальная часть не пуста
            var local = email.Substring(0, atIndex);
            if (string.IsNullOrEmpty(local))
            {
                return false;
            }
            // Домен должен содержать хотя бы одну точку и не начинаться/заканчиваться точкой
            var domain = email.Substring(atIndex + 1);
            if (string.IsNullOrEmpty(domain) || !domain.Contains('.') || domain.StartsWith(".") || domain.EndsWith("."))
            {
                return false;
            }
            return true;
        }
    }
}