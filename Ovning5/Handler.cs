using Ovning5.garage;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ovning5
{
    public class Handler:IHandler
    {
        public Handler()
        {
            
        }

        Garage<Vehicle> garage = null!;

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
            var query = from s in garage  where s.Registration.Equals(reg.ToUpper()) select s;
            Vehicle v = query.FirstOrDefault()!;
            Vehicle result = garage.removeVehicle(v);
            return result;
        }

        public Vehicle parkVehicle(Vehicle car)
        {
            return garage.parkVehicle(car);
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
