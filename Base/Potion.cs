using System;

namespace baseClasses
{
    abstract class Potion
    {
        private int _extraHealth;
        private int _extraDamage;
        private int _extraArmor;
        private int _speed;

        public Potion(int extraHealth, int extraDamage, int extraArmor) {
            _extraHealth = extraHealth;
            _extraDamage = extraDamage;
            _extraArmor = extraArmor;
        }

        public Potion(int extraHealth) {
            _extraHealth = extraHealth;
        }

        public Potion(int extraDamage) {
            _extraDamage = extraDamage;
        }

        public Potion(int extraArmor) {
            _extraArmor = extraArmor;
        }

        public Potion(int speed) {
            _speed = speed;
        }
    }
}