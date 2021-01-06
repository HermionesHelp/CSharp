using System;
using System.Collections.Generic;
using System.Text;

namespace namespace Classes.Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Item flint = new Item("Flint", "Used to start fire", 10, 10);
            Item rope = new Item("Rope", "Ties things together, lets you climb things", 10, 10);
            Item healingPotion = new Item("Healing Potion", "Restore healths - Tastes terrible", 10, 20);

            Item[] inventory = { flint, rope, healingPotion };

            Shop ourShop = new Shop("Bilbo's Knicknacks", inventory);

            ourShop.RunShop();
        }

    }
}
