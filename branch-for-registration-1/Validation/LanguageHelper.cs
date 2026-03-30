using System.Globalization;
using System.Resources;
using System.Threading;

namespace branch_for_registration_1.ValidationTextBox
{
    /// <summary>
    /// Вспомогательный класс для работы с локализацией
    /// </summary>
    public static class LanguageHelper
    {
        private static CultureInfo currentCulture;
        private static ResourceManager resourceManager = Properties.Resources.ResourceManager;

        static LanguageHelper()
        {
            SetLanguage("ru"); // по умолчанию русский
        }
        /// <summary>
        /// Устанавливает язык интерфейса
        /// </summary>
        /// <param name="languageCode">Код языка (ru, en)</param>
        public static void SetLanguage(string languageCode)
        {
            currentCulture = new CultureInfo(languageCode);
            Thread.CurrentThread.CurrentUICulture = currentCulture;
        }
        /// <summary>
        /// Возвращает локализованную строку по ключу
        /// </summary>
        /// <param name="key">ключ</param>
        /// <returns></returns>
        public static string GetString(string key)
        {
            return resourceManager.GetString(key, currentCulture) ?? key;
        }
    }
}