using System;
using System.Collections.Generic;
using System.Text;

namespace Lists.Hints
{
    class Hints
    {
        /* We're going on an adventure! But before we can go we have to pack our inventory for the journey using a list. 

              To go on our adventure we have gold, a flint, a rope, a healing potion, a dagger, a bedroll, 
              a loaf of bread, and a tin whistle. 

              1. Create a list called "inventory" that contains each of these items
                
                 You'll need to create a new List that will hold strings to represent each of the items we want to put into our inventory

              2. Log the contents of your inventory displaying the items.
                   
                    You'll need a foreach loop to do this       
              */


        /* As your adventure goes on your party reaches a shop. Now is a good time to restock.
         Your inventory can hold 10 items. 

        The shop currently has:  
        Loaf of Bread
        Ham Hock
        Long Sword
        Short Bow
        Healing Potion
        Backpack  <- allows you to carry 10 more items
        Small Silver Key

        3. Choose some items to buy and add those items to your inventory. 
            - If you purchase more of an item you already have it will take an additional slot in your inventory.

                When using the .Add method don't forget to call your list, and then pass the information you're adding as an argument.

            - remember it can only hold 10 items so if you buy the backpack you can add items there
            ... which means making a new List. 

        4. Log the contents of your inventory (and backpack if you have one) 

            Should look familiar. Just adding another List if you needed one.

        5. Display a Count of the number of items in your inventory(& backpack).
        

             Don't forget to check out the chapter for Methods and Properties of Lists. (3.4)
              https://education.launchcode.org/csharp-web-development/chapters/control-flow-and-collections/list.html

       
        Your party mates HATE your tin whistle, lets just say you're not the greatest musician in the world, ok. 
        The shop keeper will buy it from you for 10 gold.

        6. Remove the Tin Whistle from your inventory.
        */


        /* 
         Your party comes across a witch in the middle of your path. 

        She says that if any member of your party has a Small Silver Key she'll allow you to pass. 
        If it doesn't she will destroy you all. 

        7. Search your inventory(& backpack) to see if it contains a Small Silver Key. If it does the witch will tell you "You may pass."
         If not she will cast "Fireball" at you. 

          This is a great place for an If statement to handle searching your inventory (and backpack if you have one) and what will happen if 
          you don't meet her requirements. 

         */
    }
}
