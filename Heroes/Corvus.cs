using Base.baseclass;
namespace  Heroes
    class Corvus : Hero
{
    public Corvus() : base(name, level, health, damage, armor, speed)
    {
        this.name = "Corvus";
        this.level = 1;
        this.health = 150;
        this.damage = 25;
        this.armor = 20;
        this.speed = 5;
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
    }
    public void UsePotion()
    {
        throw new System.NotImplementedException();
    }
    public void UsePowerUp()
    {
        throw new System.NotImplementedException();
    }
    public void Run()
    {
        throw new System.NotImplementedException();
    }
    public void Equip()
    {
        throw new System.NotImplementedException();
    }
    public void Unequip()
    {
        throw new System.NotImplementedException();
    }
    
}