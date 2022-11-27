using Ovning5.garage;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ovning5.ui
{
    public class Menu_Search : IMenu
    {
        private Menu_Main menu_Main;

        public Menu_Search(Menu_Main menu_Main)
        {
            this.menu_Main = menu_Main;
        }
        public IMenu interact(IUI ui, IHandler handler)
        {
            switch (ui.askForIntInput("Choose an option"))
            {
                case GlobalConstants.MenuOptionListAllParked:
                    Console.WriteLine($"Model                        Color     Wheels    Registration");
                    Console.WriteLine($"-------------------------------------------------------------");

                    foreach (Vehicle vehicle in handler)
                    {
                        Console.WriteLine(
                            $"{vehicle.Model,-25}|{vehicle.Color,10}|{vehicle.NrOfWheels,10}|{vehicle.Registration,10}");
                    }
                    Console.WriteLine();
                    return this;
                    break;
                case GlobalConstants.MenuOptionListType:
                    return this;
                    break;
                case GlobalConstants.MenuOptionFindByRegistation:
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
            Console.WriteLine("[------------Search---Garage------------------]");
            Console.WriteLine($"{GlobalConstants.MenuOptionFindByRegistation} Find by registration");
            Console.WriteLine($"{GlobalConstants.MenuOptionListAllParked} List all parked");
            Console.WriteLine($"{GlobalConstants.MenuOptionListType} List types");
            Console.WriteLine($"{GlobalConstants.MenuOptionReturn} Return to main menu");
        }
    }
}
