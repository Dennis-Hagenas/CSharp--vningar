using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning5.garage
{
    public interface IVehicle
    {
        string Model { get; set; }
        string Color { get; set; }
        int NrOfWheels { get; set; }
        string Registration { get; set; }
    }
}
