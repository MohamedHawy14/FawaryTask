using FawaryTask.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawaryTask.Classes
{
    public class Car
    {
        private IEngine _engine;
        public int CurrentSpeed => _engine.Speed;

        public Car(IEngine engine)
        {
            _engine = engine;
        }

        public void ReplaceEngine(IEngine newEngine)
        {
            _engine = newEngine;
            Console.WriteLine("Engine replaced successfully!");
        }

        public void Accelerate()
        {
            if (CurrentSpeed + 20 <= 200)
            {
                for (int i = 0; i < 20; i++) _engine.Increase();
                Console.WriteLine($"Accelerated. Current Speed: {CurrentSpeed}");
            }
        }

        public void Brake()
        {
            if (CurrentSpeed >= 20)
            {
                for (int i = 0; i < 20; i++) _engine.Decrease();
                Console.WriteLine($"Braking. Current Speed: {CurrentSpeed}");
            }
        }

        public void Start() => Console.WriteLine("Engine Started at 0 speed.");

        public void Stop()
        {
            if (CurrentSpeed == 0) Console.WriteLine("Engine Stopped.");
            else Console.WriteLine("Error: Must be at 0 speed to stop!");
        }
    }
}
