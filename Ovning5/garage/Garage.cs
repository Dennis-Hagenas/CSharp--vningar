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
            vehicles[firstFreeSlot++] = vehicle;
            return vehicles[firstFreeSlot];
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

        public T removeVehicle(T vehicle)
        {
            return null;
        }
    }
}
