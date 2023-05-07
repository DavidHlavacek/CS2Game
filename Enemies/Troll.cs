using System;
using Base.Enemie;

namespace Enemies
{
    public class Troll : Enemie
    {
        public Troll : base("Troll", 5, 200, 50, 100, 0.5)
        {
        }
            
        public void Attack()
        {
            throw new System.NotImplementedException();
        }

        public void Run()
        {
            throw new System.NotImplementedException();
        }
    }
}

