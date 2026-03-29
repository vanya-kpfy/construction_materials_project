using System;

namespace branch_for_registration_1.DTO
{
    public class ProductDto
    {
        public Guid Id { get; set; }
        public string Article { get; set; }
        public string Name { get; set; }
        public string CategoryName { get; set; }
        public string Unit { get; set; }
        public decimal PurchasePrice { get; set; }
        public int CurrentStock { get; set; }
    }
}
