using System;

namespace baseClasses
{
    abstract class PowerUp : IPlayerOption
    {
        private int damage;
        //attack speed
        private int speed;

        public PowerUp(int damage, int speed)
        {
            this.damage = damage;
            this.speed = speed;
        }
        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        
    }
}