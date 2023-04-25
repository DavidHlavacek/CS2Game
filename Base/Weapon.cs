using System;

namespace baseClasses
{
    abstract class Weapon
    {
        private string _name;
        private int _level;
        private int _health;
        private int _damage;
        private int _fireSpeed;
        private object _special;

        public Weapon(string name, int level, int health, int damage, int fireSpeed, object _special) {
            _name = name;
            _level = level;
            _health = health;
            _damage = damage;
            _fireSpeed = fireSpeed;
            _special = special;
        }
    }
}