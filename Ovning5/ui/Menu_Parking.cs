using Ovning5.garage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning5.ui
{
    public class Menu_Parking : IMenu
    {
        private Menu_Main menu_Main;

        public Menu_Parking(Menu_Main menu_Main)
        {
            this.menu_Main = menu_Main;
        }

        public IMenu interact(IUI ui, IHandler handler)
        {
            switch (ui.askForIntInput("Choose an option"))
            {
                case GlobalConstants.MenuOptionParking:
                    return this;
                    break;

                case GlobalConstants.MenuOptionRemoveVehicle:
                    string reg = ui.askForStringInput("Enter registration number");
                    Vehicle result = handler.remove(reg);
                    if (result != null) Console.WriteLine(
                            $"Succesfully removed\n{result.Model,-25}|{result.Color,10}|{result.NrOfWheels,10}|{result.Registration,10}");
                    else 
                        Console.WriteLine("Vehicle is not in garage");
                    return this;
                    break;

                case GlobalConstants.MenuOptionReturn:
                    return menu_Main;
                    break;
                default:
                    return this;
                    break;
            }
        }

        public void print()
        {
            Console.WriteLine("[------------Park----Vehicle-------------]");
            Console.WriteLine($"{GlobalConstants.MenuOptionPark} Park vehicle");
            Console.WriteLine($"{GlobalConstants.MenuOptionReturn} Return to main menu");
        }
    }
}
