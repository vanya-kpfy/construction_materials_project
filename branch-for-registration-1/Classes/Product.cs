using System;

namespace branch_for_registration_1.Classes
{
    /// <summary>
    /// Модель класса для товаров
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Уникальный идентификатор товаров (GUID)
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Артикул (уникальный)
        /// </summary>
        public string Article { get; set; } 
        /// <summary>
        /// Наименование товара
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Внешний ключ на Category
        /// </summary>
        public Guid CategoryId { get; set; }
        /// <summary>
        /// Единица измерения
        /// </summary>
        public string Unit { get; set; }
        /// <summary>
        /// Цена закупки
        /// </summary>
        public decimal PurchasePrice { get; set; }
        /// <summary>
        /// Текущий остаток
        /// </summary>
        public int CurrentStock { get; set; } 
        /// <summary>
        /// Свойство
        /// </summary>
        public Category Category { get; set; }
    }
}