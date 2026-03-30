using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace branch_for_registration_1.DataBase.Models
{
    public class Address
    {
        /// <summary>
        /// ID адреса
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Страна для отгрузки
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Город для отгрузки
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Регион для отгрузки
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Улица для отгрузки
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// Здание для отгрузки
        /// </summary>
        public string Building { get; set; }

        /// <summary>
        /// Полный адрес до пользователя, кому отгружаем
        /// </summary>
        [NotMapped]
        public string FullAddress => $"{Country}, {Region},{City}, {Street}, {Building}";
    }
}
