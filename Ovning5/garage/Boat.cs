namespace Ovning5.garage
{
    internal class Boat : Vehicle
    {
        public Boat(string model, string color, int antalHjul, string regnummer, double length) : base(model, color, antalHjul, regnummer)
        {
            Length = length;
        }

        public double Length { get; }
    }
}
