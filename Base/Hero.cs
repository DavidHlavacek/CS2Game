using System;

namespace baseClasses
{
    abstract class Hero
    {
        private string _name;
        private int _level;
        private int _health;
        private int _damage;
        private int _armor;
        private int _speed;

        public Hero(string name, int level, int health, int damage, int armor) {
            _name = name;
            _level = level;
            _health = health;
            _damage = damage;
            _armor = armor;
        }
    }
}