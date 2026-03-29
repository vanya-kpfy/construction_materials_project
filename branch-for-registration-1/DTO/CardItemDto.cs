using System;

namespace branch_for_registration_1.DTO
{
    public class CartItemDto
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public int Stock { get; set; }
    }
}
