using FawaryTask.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawaryTask.Classes
{
    public abstract class BaseEngine : IEngine
    {
        public int Speed { get; protected set; } = 0;
        public virtual void Increase() => Speed++;
        public virtual void Decrease() => Speed--;
    }
}
