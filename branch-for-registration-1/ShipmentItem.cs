using System;

namespace branch_for_registration_1.Classes
{
    /// <summary>
    /// Позиция отгрузки – связывает отгрузку с товаром и указывает количество.
    /// </summary>
    public class ShipmentItem
    {
        /// <summary>
        /// Уникальный идентификатор позиции
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Идентификатор отгрузки, к которой относится эта позиция
        /// </summary>
        public Guid ShipmentId { get; set; }
        /// <summary>
        /// Идентификатор товара, который был отгружён
        /// </summary>
        public Guid ProductId { get; set; }
        /// <summary>
        /// Количество отгруженного товара
        /// </summary>
        public int Quantity { get; set; }
        /// <summary>
        /// Навигационное свойство – сама отгрузка
        /// </summary>
        public Shipment Shipment { get; set; }
        /// <summary>
        /// Навигационное свойство – сам товар
        /// </summary>
        public Product Product { get; set; }
    }
}