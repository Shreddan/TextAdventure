using System;
using System.Collections.Generic;
using System.Text;

namespace TextAdventure
{
    class Commands
    {
        Engine engine = new Engine();
        public static bool running = true;

        public Commands()
        { 
            engine.Init();
        }

        public bool Loop()
        {
            while (running)
            {
                engine.Update();
            }

            return running;
        }

        public static void ParseCommand(string command)
        {
            if (command.Length > 0)
            {
                
            }
        }

        
       
    }
}
