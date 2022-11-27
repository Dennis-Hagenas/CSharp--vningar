using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning5.garage
{
    public class Car : Vehicle, IVehicle
    {
        public Car(string model, string color, int antalHjul, string regnummer, int year) : base(model, color, antalHjul, regnummer)
        {
            Year = year;
        }

        public int Year { get; }
    }
}
