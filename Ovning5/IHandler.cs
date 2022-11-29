using Ovning5.garage;

namespace Ovning5
{
    public interface IHandler : IEnumerable<Vehicle>
    {
        int getFreeParkingSpace();
        void createGarage(int size);
        IEnumerator<Vehicle> getEnumerator();
        int getGarageSize();
        Vehicle parkVehicle(Vehicle car);
        Vehicle remove(string reg);
    }
}
