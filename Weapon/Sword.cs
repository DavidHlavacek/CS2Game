using System;
using Base.Weapon;
namespace Weapon
{
    public class Sword : Weapon
    {
        public Sword() : base("Sword", 1, 100, 20, 1 , null)
        {
        }
        public void Attack()
        {
            Console.WriteLine("You attacked with a sword.");
        }
    }
    

}
