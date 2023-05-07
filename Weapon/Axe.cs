using System;
using Base.Weapon;

namespace Weapon
{
    public class Axe : Weapon
    {
        public Axe() : base("Axe",1,150, 15, 1 ,null)
        {
        }
    }
    public void Attack()
    {
        Console.WriteLine("You attacked with an axe.");
    }
}

