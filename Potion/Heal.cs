using System;
using Base.Potion;

namespace Potion
{
    public class HealPotion : Potion
    {
        public HealPotion(int addHealth) : base(addHealth)
        {
            this._addHealth = addHealth;
        }

        public int _addHealth { get; set; }

        public void UsePotion()
        {
            Console.WriteLine("You used a heal potion and gained " + _addHealth + " health.");
        }
    }
}
