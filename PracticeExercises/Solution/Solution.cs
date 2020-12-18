using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionaries.Solution
{
    class Solution
    {
        static void Main(string[] args)
        {/*
            // 1.
            Dictionary<string, int> inventory = new Dictionary<string, int>
            {
                {"Gold", 500 },
                {"Flint", 1 },
                {"Healing Potion", 2 },
                {"Tin Whistle", 1 },
                {"Dagger", 1 },
                {"Rope", 1 },
                {"Bedroll", 1 },
                {"Loaf of Bread", 1 }
            };
            //2.
            foreach (KeyValuePair<string, int> item in inventory)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            };

            //3. 
            inventory["Gold"] = 140;
            // 4.
            inventory.Add("Small Silver Key", 1);
            inventory.Add("Long Sword", 1);
            inventory["Loaf of Bread"] = 6;
            inventory["Healing Potion"] = 4;

            Dictionary<string, int> backpack = new Dictionary<string, int>
           {
               {"Ham Hock", 5 },
               {"Short Bow", 1 }
           };
            // 5. 
            foreach (KeyValuePair<string, int> item in inventory)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            };

            Console.WriteLine(inventory.Count);

            foreach (KeyValuePair<string, int> item in backpack)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }

            //6.  
            Console.WriteLine("Inventory Count: " + inventory.Count);
            Console.WriteLine("Backpack Count: " + backpack.Count);

            //7. 
            inventory.Remove("Tin Whistle");

            //8. 
            inventory["Gold"] = 150;

            //9. 
            if (inventory.ContainsKey("Small Silver Key") || backpack.ContainsKey("Small Silver Key"))
            {
                Console.WriteLine("You may pass.");
            }
            else
            {
                Console.WriteLine("FIREBALL!!!");
            }*/
        }
    }
}
