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

            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }
    }
}