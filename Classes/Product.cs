using System;

namespace branch_for_registration_1.Classes
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Article { get; set; }        // артикул (уникальный)
        public string Name { get; set; }
        public Guid CategoryId { get; set; }        // внешний ключ на Category
        public string Unit { get; set; }            // единица измерения
        public decimal PurchasePrice { get; set; }  // цена закупки
        public int CurrentStock { get; set; }       // текущий остаток

        // Навигационное свойство
        public Category Category { get; set; }
    }
}