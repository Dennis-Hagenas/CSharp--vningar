using System.Collections;

namespace Ovning5.garage
{
    class GarageEnumerator<T> : IEnumerator<T> where T : Vehicle
    {
        int current = -1;
        private object[] vehicles;
        private int firstFreeSlot;


        public GarageEnumerator(object[] vehicles, int firstFreeSlot)
        {
            this.vehicles = vehicles;
            this.firstFreeSlot = firstFreeSlot;
        }

        object IEnumerator.Current => vehicles[current];

        T IEnumerator<T>.Current => (T)vehicles[current];

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            current++;
            if (current < firstFreeSlot)
                return true;
            return false;
        }

        public void Reset()
        {
            current = -1;
        }
    }
}
