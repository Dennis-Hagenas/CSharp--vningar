using System.Collections;

namespace Ovning5.garage
{
    public class Garage<T> : IGarage<T>, IEnumerable<T> where T : Vehicle
    {
        public int firstFreeSlot;
        public T[] vehicles;

        public Garage(int size)
        {
            firstFreeSlot = 0;
            vehicles = new T[size];
        }

        public T parkVehicle(T vehicle)
        {
            if (firstFreeSlot >= vehicles.Length) return null!;
            vehicles[firstFreeSlot++] = vehicle;
            return vehicle;
        }

        public int size()
        {
            return vehicles.Length;
        }

       public IEnumerator<T> GetEnumerator()
        {
            return new GarageEnumerator<T>(vehicles, firstFreeSlot);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new GarageEnumerator<T>(vehicles, firstFreeSlot);
        }

        public T removeVehicle(T removed)
        {
            if (removed == null) return null;
            T result = null!;
            int pos = -1;

            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] == removed)
                {
                    result = vehicles[i];
                    vehicles[i] = null;
                    pos = i;
                    break;
                }
            }
            if (result!=null)
            {
                for(int i = pos; i < (vehicles.Length-1); i++)
                {
                    vehicles[i] = vehicles[i + 1];
                }
                //vehicles[vehicles.Length - 1] = null;
                firstFreeSlot--;
            }
            return result!;
        }
    }
}
