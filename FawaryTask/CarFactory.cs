using FawaryTask.Classes;
using FawaryTask.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawaryTask
{
    public static class CarFactory
    {
        public static Car CreateCar(string type)
        {
            IEngine engine = type.ToLower() switch
            {
                "gas" => new GasolineEngine(),
                "electric" => new ElectronicEngine(),
                "hybrid" => new MixedHybridEngine(),
                _ => throw new ArgumentException("Unknown engine")
            };
            return new Car(engine);
        }
    }
}
