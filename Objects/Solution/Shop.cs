using System;
using System.Collections.Generic;
using System.Text;

namespace Objects.Solution
{
    class Shop
    {
        public string Name { get; private set; }
        public Item[] Inventory { get; private set; }

        public Shop(string name, Item[] inventory)
        {
            Name = name;
            Inventory = inventory;
        }
   
        public void ShopGreeting()
        {
            Console.WriteLine($"Welcome to {this.Name}. Purveryors of the highest quality goods from across the realm.\n Would you like to see our current stock? Yes or No");
            string response = Console.ReadLine();
            if (response.ToLower() == "yes")
            {
                this.GetInventory(this.Inventory);
            }
        }

        public void GetInventory(Item[] inventory)
        {
            string name = "";
            string description = "";
            int quantity = 0;
            int price = 0;
            foreach (Item item in inventory)
            {
                name = item.Name;
                description  = item.Description;
                quantity = item.Quantity;
                price = item.Price;
                Console.WriteLine($"{name} \n Description: {description} \n I have {quantity}, they cost {price} gold.\n");
            }
           
        }
    }
}
