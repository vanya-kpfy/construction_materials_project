using System;
using System.Collections.Generic;

namespace branch_for_registration_1.Classes
{
    public class Shipment
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }            // кто отгрузил
        public DateTime ShipmentDate { get; set; }
        public string Destination { get; set; }     // куда отгружают

        // Навигационные свойства
        public User User { get; set; }
        public List<ShipmentItem> ShipmentItems { get; set; }
    }
}