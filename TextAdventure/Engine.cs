using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace TextAdventure
{
    class Engine
    {
        List<Items.Weapons> weps = new List<Items.Weapons>();
        List<Items.Armour> armours = new List<Items.Armour>();
        List<Entity.Entity> entities;

        public void Init()
        {
            GetItems(weps, armours);

        }

        public void Update()
        {
            inputHandler();
        }

        public void GetItems(List<Items.Weapons> weps, List<Items.Armour> armours)
        {
            Items.Weapons weapon = new Items.Weapons();
            
            if (File.Exists(weapon.path))
            {
                Console.WriteLine("File Found");
                Console.WriteLine();
                Console.WriteLine();
                IEnumerable<string> vs = File.ReadLines(weapon.path);
                foreach (string wep in vs)
                {
                    string[] name = wep.Split(',');
                   
                    Items.Weapons weapons = new Items.Weapons();
                    weapons.Name = name[0];
                    weapons.Level = Int32.Parse(name[1]);
                    weapons.Weight = Int32.Parse(name[2]);
                    weapons.Value = Int32.Parse(name[3]);
                    weapons.baseDamage = Int32.Parse(name[4]);
                    weps.Add(weapons);
                }

                
            }
            else
            {
                Console.WriteLine("File not Found");
                Console.WriteLine(weapon.path);
            }
        }

        public void DisplayItems(List<Items.Weapons> weps)
        {
            foreach (Items.Weapons wepo in weps)
            {
                Console.WriteLine("Name : " + wepo.Name);
                Console.WriteLine();
                Console.WriteLine("Level : " + wepo.Level);
                Console.WriteLine("Weight : " + wepo.Weight);
                Console.WriteLine("Value : " + wepo.Value);
                Console.WriteLine("Base Damage : " + wepo.baseDamage);
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        public void inputHandler()
        {
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.Escape:
                    {
                        Commands.running = false;
                        break;
                    }
                case ConsoleKey.Enter:
                    {
                        string cmd = Console.ReadLine();
                        Commands.ParseCommand(cmd);
                        break;
                    }
            }
        }

    }
}
