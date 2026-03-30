using System;

namespace branch_for_registration_1.DTO
{
    /// <summary>
    /// Класс, который представляет товар, добавленный в отгрузку. Содержит информацию: ID, название, кол-во, остаток
    /// </summary>
    public class CartItemDto
    {
        /// <summary>
        /// ID товара
        /// </summary>
        public Guid ProductId { get; set; }

        /// <summary>
        /// Название товара
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// Количество товара в отгрузке
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Остаток товара на складе
        /// </summary>
        public int Stock { get; set; }
    }
}