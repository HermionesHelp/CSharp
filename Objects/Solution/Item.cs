using System;
using System.Collections.Generic;
using System.Text;

namespace Objects.Solution
{
    class Item
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public int Quantity { get; set; }
        public int Price { get; private set; }

        public Item (string name, string  description, int quantity, int price)
        {
            Name = name;
            Description = description;
            Quantity = quantity;
            Price = price;
        }
 
    }
}
