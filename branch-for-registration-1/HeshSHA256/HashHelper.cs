using System.Security.Cryptography;
using System.Text;

namespace branch_for_registration_1.HeshSHA256
{
    /// <summary>
    /// Kласс для хеширования паролей с помощью алгоритма SHA256.
    /// </summary>
    public static class HashHelper 
    {
        public static string GetHash(string input) // Преобразует входную строку (пароль) в хеш-строку.
        {
            using (SHA256 sha256 = SHA256.Create())  // cоздаём объект SHA256 (использовать блок using, чтобы освободить ресурсы)
            {
                byte[] bytes = Encoding.UTF8.GetBytes(input);  // преобразуем строку в массив байтов (кодировка UTF8)
                // Вычисляем хеш
                byte[] hash = sha256.ComputeHash(bytes);
                // Строим строку из байтов хеша в шестнадцатеричном формате
                StringBuilder sb = new StringBuilder(); 
                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("x2"));  // Каждый байт превращаем в два шестнадцатеричных символа (x2)
                }
                return sb.ToString();
            }
        }

        /// <summary>
        /// Метод, который проверяет пароли на совпадение
        /// </summary>
        /// <param name="inputPassword"></param>
        /// <param name="storedHash"></param>
        /// <returns></returns>
        public static bool VerifyPassword(string inputPassword, string passwordHashInDB)
        {
            var hashOfInput = GetHash(inputPassword);
            return hashOfInput == passwordHashInDB;
        }
    }
}