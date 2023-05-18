using Base.baseclass;

namespace  Hero
    class Ajax : Hero
{
    public Ajax() : base(name, level, health, damage, armor, speed)
    {
        this.name = "Ajax";
        this.level = 1;
        this.health = 200;
        this.damage = 10;
        this.armor = 25;
        this.speed = 10;
    }

    public string Name{ get; set; }
    public int Level { get; set; }
    public int Health { get; set; }
    public int Damage { get; set; }
    public int Armor { get; set; }
    public int Speed { get; set; }

    public void Attack()
    {
        throw new System.NotImplementedException();
        // Put some kind of attack here
    }

    public void UsePotion()
    {
        throw new System.NotImplementedException();
        // Use Armor/Heal/Speed potions here
    }

    public void UsePowerUp()
    {
        throw new System.NotImplementedException();
        // Use Shock/Fire/Ice/Poison powers here
    }

    public void Run()
    {
        throw new System.NotImplementedException();
    }

    public void Equip()
    {
        throw new System.NotImplementedException();
        // Equip weapon
    }

    public void Unequip()
    {
        throw new System.NotImplementedException();
        // Unequip weapon
    }
}