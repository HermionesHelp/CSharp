using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
   /* class Shop
    {
        public string Name { get; private set; }
        public Item[] Inventory { get; private set; }

        public Shop(string name, Item[] inventory)
        {
            Name = name;
            Inventory = inventory;
        }

        public void RunShop()
        {
            Console.WriteLine($"Welcome to {this.Name}. Purveryors of the highest quality goods from across the realm.\n Would you like to see our current stock? Yes or No");
            string response = Console.ReadLine();
            if (response.ToLower() == "yes")
            {
                this.GetInventory(this.Inventory);
                this.SellItem(this.Inventory);
            }
            else
            {
                Console.WriteLine("Well go away then!");
            }
        }

        public void GetInventory(Item[] inventory)
        {
            foreach (Item item in inventory)
            {
                Console.WriteLine($"{item.Name} \n Description: {item.Description} \n I have {item.Quantity}, they cost {item.Price} gold.\n");
            }

        }

        public void SellItem(Item[] inventory)
        {
            Console.WriteLine("Would you like to buy something? Yes or No");
            string buyIt = Console.ReadLine();

            while (buyIt.ToLower() == "yes")
            {
                Console.WriteLine("What would you like to purchase? (or press Enter when done buying)");
                string response = Console.ReadLine();

                if (response != "")
                {

                    foreach (Item item in inventory)
                    {
                        if (item.Name.ToLower().Contains(response.ToLower()))
                        {
                            Console.WriteLine("How many would you like to buy?");
                            int amount = Convert.ToInt32(Console.ReadLine());

                            if (amount <= item.Quantity && amount != 0)
                            {
                                item.Quantity -= amount;
                                Console.WriteLine($"{item.Name} now has {item.Quantity} left.");
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Thanks for visiting!");
                    break;
                }
            }
        }
    }*/
}
