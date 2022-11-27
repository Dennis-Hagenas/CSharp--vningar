using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning5.garage
{
    internal class Motorcycle : Vehicle
    {
        public Motorcycle(string model, string color, int antalHjul, string regnummer, double cylinderVolume) : base(model, color, antalHjul, regnummer)
        {
            CylinderVolume = cylinderVolume;
        }

        public double CylinderVolume { get; }
    }
}
