using System.Runtime.CompilerServices;

namespace Ovning5.ui
{
    public class Menu_Main : IMenu
    {
        public void print()
        {
            Console.WriteLine("[-----------Main---Menu----------------]");
            Console.WriteLine($"{GlobalConstants.MenuOptionParking} Park and remove vehicles");
            Console.WriteLine($"{GlobalConstants.MenuOptionSearch} Garage Inventory Functions");
            Console.WriteLine($"{GlobalConstants.MenuOptionMaintenance} Database maintenance operations");
            Console.WriteLine($"{GlobalConstants.MenuOptionQuit} Quit");
        }
        public IMenu interact(IUI ui, IHandler handler)
        {
            switch (ui.askForIntInput("Choose an option"))
            {
                case GlobalConstants.MenuOptionParking:
                    return new Menu_Parking(this);
                    break;
                case GlobalConstants.MenuOptionSearch:
                    return new Menu_Search(this);
                    break;
                case GlobalConstants.MenuOptionMaintenance:
                    return new Menu_GarageMaintenance(this);
                    break;
                case GlobalConstants.MenuOptionQuit:
                    return null;
                    break;
                default:
                    return this;
                    break;
            }
        }
    }
}