using System;

namespace branch_for_registration_1.DTO
{
    /// <summary>
    /// Класс, который представляет данные о товаре для отображения в приложении
    /// </summary>
    public class ProductDto
    {
        /// <summary>
        /// ID товара
        /// </summary>
        public Guid Id { get; set; }
        
        /// <summary>
        /// Артикул товара
        /// </summary>
        public string Article { get; set; }

        /// <summary>
        /// Название товара
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Название категории
        /// </summary>
        public string CategoryName { get; set; }

        /// <summary>
        /// Единица измерения
        /// </summary>
        public string Unit { get; set; }

        /// <summary>
        /// Цена закупки
        /// </summary>
        public decimal PurchasePrice { get; set; }

        /// <summary>
        /// Текущий остаток на складе
        /// </summary>
        public int CurrentStock { get; set; }
    }
}
