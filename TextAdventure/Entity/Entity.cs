using System;
using System.Collections.Generic;
using System.Text;

namespace TextAdventure.Entity
{
    class Entity
    {
        protected int healthMax;
        protected int health;
        protected int Level;
        protected int defence;
        protected int baseDamage;
        protected int Money;

        protected virtual void AI()
        {

        }
    }
}
