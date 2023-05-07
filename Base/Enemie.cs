using System;

namespace baseClasses
{
    public class Enemie : IPlayerOption
    {
        private string _name;
        private int _level;
        private int _health;
        private int _damage;
        private int _armor;
        private double _speed;

        public Enemie(string _name, int _level, int _health, int _damage, int _armor, double _speed)
        {
            this._name = _name;
            this._level = _level;
            this._health = _health;
            this._damage = _damage;
            this._armor = _armor;
            this._speed = _speed;
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                this._name = value;
            }

        }
        
        public int Level
        {
            get
            {
                return this._level;
            }
            set
            {
                this._level = value;
            }
        }
        
        public int Health
        {
            get
            {
                return this._health;
            }
            set
            {
                this._health = value;
            }
        }
        
        public int Damage
        {
            get
            {
                return this._damage;
            }
            set
            {
                this._damage = value;
            }
        }
        
        public int Armor
        {
            get
            {
                return this._armor;
            }
            set
            {
                this._armor = value;
            }
        }
        
        public double Speed
        {
            get
            {
                return this._speed;
            }
            set
            {
                this._speed = value;
            }
        }
    }

}
