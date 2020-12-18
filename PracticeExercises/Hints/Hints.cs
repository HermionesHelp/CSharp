using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionaries.Hints
{
    class Hints
    {
        /* We're going on an adventure! But before we can go we have to pack our inventory for the journey. 

        To go on our adventure we have 500 Gold, a flint, a rope, 2 healing potions, a dagger, a bedroll, 
        a loaf of bread, and a tin whistle. 

        1. Create a dictonary called "inventory" that contains each of these items and their values

             Your dictionary will contain keys for the name each item and values for the amount of each item.

        2. Log the contents of your inventory displaying the items and how many of each you have.

            You will need a foreach loop to do this. 

        */


        /* As your adventure goes on your party reaches a shop. Now is a good time to restock.
         Your inventory can hold 10 items (counted by Key not by Value). 

        The shop currently has an unlimited amount of each item. 
        Loaf of Bread - 2 gold
        Ham Hock - 5 gold
        Long Sword - 100 gold
        Short Bow - 75 gold
        Healing Potion - 25 gold
        Backpack - 75 gold  <- allows you to carry 10 more items
        Small Silver Key - 25 gold

        3. Choose some items to buy, calculate and update the amount of gold in your pocket.

            The easiest way to do this is to calculate the value of the items you want and then
            reassign the value of the gold in your inventory.


        4. Add those items to your inventory.
           - If you purchase more of an item you already have be sure to update that value instead of adding 
            a new item to your storage. No need to take up a valuable slot.

                You can update an already existing Key's value by reassigning it. 

            - remember it can only hold 10 items so if you buy the backpack you can add items there
            ... which means making a new dictionary.

                When using the .Add method don't forget to call your dictionary, and then pass the information you're adding as an argument.

        5. Log the contents of your inventory (and backpack if you have one) 

            Should look familiar. Just adding another dictionary if you needed one.

        6. Display a Count of the number of items in your inventory(& backpack).

            Don't forget to check out the chapter for Methods and Properties of dictionaries. (3.6.1)
              https://education.launchcode.org/csharp-web-development/chapters/control-flow-and-collections/dictionary.html

        */
        /*
         Your party mates HATE your tin whistle, lets just say you're not the greatest musician in the world, ok. 
         The shop keeper will buy it from you for 10 gold.

         7. Remove the Tin Whistle from your inventory.



         8. Update your Gold
         */

        /* 
         Your party comes across a witch in the middle of your path. 

        She says that if any member of your party has a Small Silver Key she'll allow you to pass. 
        If it doesn't she will destroy you all. 

        9. Search your inventory to see if it contains a Small Silver Key. If it does the witch will tell you "You may pass."
         If not she will cast "Fireball" at you. 

            This is a great place for an If statement to handle searching your inventory (and backpack if you have one) and what will happen if 
          you don't meet her requirements. 

         */


    }
}
