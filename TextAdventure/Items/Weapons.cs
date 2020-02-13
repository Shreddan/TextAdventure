using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TextAdventure.Items
{
    class Weapons : Item
    {
       public Weapons()
        {

        }
        public Weapons(string Name, int Level, int Weight, int Value, int baseDamage) : base(Name, Level, Weight, Value)
        {

        }

        public int baseDamage;
        public string path = Path.GetFullPath("Resources/Weapons.txt");

    }
}
