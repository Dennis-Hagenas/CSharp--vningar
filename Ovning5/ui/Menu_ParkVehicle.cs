using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning5.ui
{
    public class Menu_ParkVehicle : IMenu
    {
        private Menu_Parking menu_Parking;

        public Menu_ParkVehicle(Menu_Parking menu_Parking)
        {
            this.menu_Parking = menu_Parking;
        }

        enum type
        {
            airplane = 1, boat, bus, car, motorcycle
        }

        public IMenu interact(IUI ui, IHandler handler)
        {
            switch (ui.askForIntInput("Choose an option"))
            {
                case GlobalConstants.MenuOptionParking:
                    return this;
                    break;

                case GlobalConstants.MenuOptionRemoveVehicle:
                    return this;
                    break;

                case 11:
                    return menu_Parking;
                    break;
                default:
                    return this;
                    break;
            }
        }

        public void print()
        {
            Console.WriteLine("Park a new vehicle");
            Console.WriteLine($"1. Type ");
            Console.WriteLine($"2. Model ");
            Console.WriteLine($"3.  ");
            Console.WriteLine($"4. Type ");
            Console.WriteLine($"10. Create vehicle ");
            Console.WriteLine($"11. Exit without saving ");

        }
    }
}
