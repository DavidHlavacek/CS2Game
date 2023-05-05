using System;

interface IPlayerOption
{
    void Attack();
    void UsePotion(Potion potion);
    void UsePowerUp(Powerup powerup);
    void Run();
    void Equip(Weapon weapon);
    void Unequip();
}

