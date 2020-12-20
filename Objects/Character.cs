using System;

namespace Objects
{
    public class Character
    {
        public string Name { get; private set; }
        public int Health { get; private set; }
        public int Mana { get; private set; }
        public int Stamina { get; private set; }

        public Character(string name)
        {
            Name = name;
            Health = 100;
            Mana = 100;
            Stamina = 100;
        }

        private int LoseHealth(int damage)
        {
            this.Health -= damage;
            return Health;
        }
        
        private int LoseMana(int magicCost)
        {
            this.Mana -= magicCost;
            return Mana;
        }

        private int LoseStamina(int staminaCost)
        {
            this.Stamina -= staminaCost;
            return Stamina;
        }

        private void CastFireball()
        {
            Console.WriteLine("Fireball!");
            this.LoseMana(10);
            this.LoseStamina(10);
        }

        private void LightWeaponAttack()
        {
            Console.WriteLine("Attack!");
            this.LoseStamina(10);
        }

        private void HeavyWeaponAttack()
        {
            Console.WriteLine("ATTACK!");
            this.LoseStamina(20);
        }

       /* static void Main(string[] args)
        {
            Character Bob = new Character("Bob");

            Console.WriteLine(Bob.Name);

            Bob.CastFireball();
            Bob.LightWeaponAttack();
            Bob.HeavyWeaponAttack();
            Console.WriteLine(Bob.Mana);
            Console.WriteLine(Bob.Health);
            Console.WriteLine(Bob.Stamina);

        }*/
    }
}
