using Ovning5.garage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning5
{
    public interface IHandler: IEnumerable<Vehicle>
    {
        public void createGarage(int size);
        public IEnumerator<Vehicle> getEnumerator();
        void parkVehicle(Vehicle car);
        Vehicle remove(string reg);
    }
}
