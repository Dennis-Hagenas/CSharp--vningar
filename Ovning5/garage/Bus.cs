namespace Ovning5.garage
{
    internal class Bus : Vehicle
    {
        public Bus(string model, string color, int antalHjul, string regnummer, string fuelType) : base(model, color, antalHjul, regnummer)
        {
            FuelType = fuelType;
        }

        public string FuelType { get; }
    }
}
