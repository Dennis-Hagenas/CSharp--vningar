﻿namespace Ovning5.garage
{
    internal class Airplane : Vehicle
    {
        public Airplane(string model, string color, int antalHjul, string regnummer, int nrOfSeats) : base(model, color, antalHjul, regnummer)
        {
            NrOfSeats = nrOfSeats;
        }

        public int NrOfSeats { get; }
    }
}
