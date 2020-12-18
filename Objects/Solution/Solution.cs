using System;
using System.Collections.Generic;
using System.Text;

namespace Objects.Solution
{
    public class Character
    {
        public string Name { get; private set; }
        public int Health { get; private set; }
        public int Mana { get; private set; }

        public Character(string name)
        {
            Name = name;
            Health = 100;
            Mana = 100;
        }

        private LoseHealth(int damage)
        {
            this.Health -= damage;
            return Health; 
        }

    }
}

