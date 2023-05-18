using System;
using Base.PowerUp;

namespace PowerUp
{
    public class Poison : PowerUp
    {
        public PoisonPowerUp(int addDamage) : base(addDamage)
        {
            this._addDamage = addDamage
        }

        public int _addArmor { get; set; }

        public void UsePowerUp()
        {
           Console.WriteLine("You used a poison potion and have a " + _addDamage + " damage multiplier.");
        }
    }
}