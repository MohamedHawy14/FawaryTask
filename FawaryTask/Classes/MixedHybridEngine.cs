using FawaryTask.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawaryTask.Classes
{
    public class MixedHybridEngine : IEngine
    {
        public int Speed { get; private set; } = 0;

        public void Increase()
        {
            Speed++;
            ChangeMode();
            //if (Speed < 50)
            //    Console.WriteLine("[Hybrid] Using Electric Mode...");
            //else
            //    Console.WriteLine("[Hybrid] Using Gas Mode...");
        }

        public void Decrease()
        {
            Speed--;
            ChangeMode();
            //if (Speed < 50)
            //    Console.WriteLine("[Hybrid] Using Electric Mode...");
            //else
            //    Console.WriteLine("[Hybrid] Using Gas Mode...");

        }

        private void ChangeMode()
        {
            if (Speed < 50)
                Console.WriteLine("[Hybrid] Using Electric Mode...");
            else
                Console.WriteLine("[Hybrid] Using Gas Mode...");
        }
    }
}
