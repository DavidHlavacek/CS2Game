using System;
using Base.Weapon;

namespace Weapon
{
    public class Spear : Weapon
    {
        public Spear() : base("Spear", 1, 100, 10, 1, null)
        {
        }
        public void Attack()
        {
            Console.WriteLine("You attacked with a spear.");
        }
    }
}