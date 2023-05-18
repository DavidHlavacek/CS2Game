using System;
using Base.Potion;

namespace Potion
{
    public class ArmorPotion : Potion
    {
        public ArmorPotion(int addArmor) : base(addArmor)
        {
            this._addArmor = addArmor
        }

        public int _addArmor { get; set; }

        public void UsePotion()
        {
            Console.WriteLine("You used a armor potion and gained " + _addArmor + " armor.");
        }
    }
}