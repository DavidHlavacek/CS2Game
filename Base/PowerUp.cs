using System;

namespace baseClasses
{
    abstract class PowerUp
    {
        private int _addDamage;

        public Potion(int addDamage) {
            _addDamage = addDamage;
        }
    }
}