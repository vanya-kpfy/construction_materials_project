using System;
using System.Collections.Generic;

namespace branch_for_registration_1.Classes
{
    /// <summary>
    /// Модель класса для категорий
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Уникальный идентификатор категории (GUID)
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Название категории
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Список товаров в этой категории
        /// </summary>
        public List<Product> Products { get; set; }
    }
}