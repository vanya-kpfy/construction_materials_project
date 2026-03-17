using System;

namespace branch_for_registration_1.Classes
{
    public class ShipmentItem
    {
        public Guid Id { get; set; }
        public Guid ShipmentId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }

        // Навигационные свойства
        public Shipment Shipment { get; set; }
        public Product Product { get; set; }
    }
}