using System;
using System.Collections.Generic;

namespace branch_for_registration_1.Classes
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        // Связь с товарами
        public List<Product> Products { get; set; }
    }
}