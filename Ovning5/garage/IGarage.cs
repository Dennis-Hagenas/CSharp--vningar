using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning5.garage
{
    public interface IGarage<T> where T : Vehicle
    {
        T parkVehicle(T vehicle);
        T removeVehicle(T vehicle);
        public int size();
    }
}
