using System;
using System.Collections.Generic;

namespace branch_for_registration_1.Classes
{
    /// <summary>
    /// Модель класса отгрузок
    /// </summary>
    public class Shipment
    {
        /// <summary>
        /// Уникальный идентификатор отгрузок (GUID)
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Кто отгрузил
        /// </summary>
        public Guid UserId { get; set; }
        /// <summary>
        /// Дата и время отгрузки
        /// </summary>
        public DateTime ShipmentDate { get; set; }
        /// <summary>
        /// Адрес или наименование получателя
        /// </summary>
        public string Destination { get; set; } 
        /// <summary>
        /// Свойство с User
        /// </summary>
        public User User { get; set; }
        /// <summary>
        /// Список позиций (товаров) в отгрузке
        /// </summary>
        public List<ShipmentItem> ShipmentItems { get; set; }
        /// <summary>
        /// Страна в форме отгрузки
        /// </summary>
        public string Country { get; set; }
        /// <summary>
        /// Город для отгрузки
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// Регион
        /// </summary>
        public string Region { get; set; }
        /// <summary>
        /// Улмца
        /// </summary>
        public string Street { get; set; }
        /// <summary>
        /// Здание
        /// </summary>
        public string Building { get; set; }
    }
}