using System;
using Base.Weapon;

namespace Weapon
{
    public class Katana : Weapon
    {
        public Katana() : base(name, level, health, damage, firepeed, special)
        {
            this.name = "Ajax";
            this.level = 1;
            this.health = 80;
            this.damage = 18;
            this.firepeed = 1.5;
            this.special = null;
        }
    }

    public void Attack()
    {
        Console.WriteLine("You attacked with an Katana.");
    }

    public void DropHealth()
    {
        // if attack is pressed, decrease health of the weapon by a certain amount every hit

        // When health reaches 50%
        Console.WriteLine("Your Katana is at 50% health");

        // When health reaches 25%
        Console.WriteLine("Your Katana is at 25% health");

        // When health reaches 10%
        Console.WriteLine("Your Katana is at 10% health");
    }
}
