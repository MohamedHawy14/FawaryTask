using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawaryTask.Interfaces
{
    public interface IEngine
    {
        int Speed { get; }
        void Increase();
        void Decrease();
    }
}
