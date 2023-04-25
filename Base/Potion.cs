using System;

namespace baseClasses
{
    abstract class Potion
    {
        private int _addHealth;
        private int _addDamage;
        private int _addArmor;
        private int _speed;

        public Potion(int addHealth, int addDamage, int addArmor) {
            _addHealth = addHealth;
            _addDamage = addDamage;
            _addArmor = addArmor;
        }

        public Potion(int addHealth) {
            _addHealth = addHealth;
        }

        public Potion(int addDamage) {
            _addDamage = addDamage;
        }

        public Potion(int addArmor) {
            _addArmor = addArmor;
        }

        public Potion(int speed) {
            _speed = speed;
        }
    }
}