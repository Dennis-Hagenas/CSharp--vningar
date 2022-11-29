namespace Ovning5.garage
{
    public interface IGarage<T> where T : Vehicle
    {
        T parkVehicle(T vehicle);
        T removeVehicle(T vehicle);
        int size();
    }
}
