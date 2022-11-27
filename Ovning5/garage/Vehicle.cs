using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning5.garage
{
    public abstract class Vehicle: IVehicle
    {
        public Vehicle(string model, string color, int antalHjul, string regnummer)
        {
            Model = model;
            Color = color;
            NrOfWheels = antalHjul;
            Registration = regnummer.ToUpper();
        }

        public string Model { get; set; }
        public string Color { get; set; }
        public int NrOfWheels { get; set; }
        public string Registration { get; set; }
    }
}
