using Ovning5.garage;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning5
{
    public class Handler:IHandler
    {
        public Handler()
        {

        }

        Garage<Vehicle> garage;

        public void createGarage(int size)
        {
            garage = new Garage<Vehicle>(size);
        }

        public IEnumerator<Vehicle> getEnumerator()
        {
            return garage.GetEnumerator();
        }

        public Vehicle remove(string reg)
        {
            return null;
        }

        public void parkVehicle(Vehicle car)
        {
            garage.parkVehicle(car);
        }

        public IEnumerator<Vehicle> GetEnumerator()
        {
            return garage.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return garage.GetEnumerator();
        }
    }
}
