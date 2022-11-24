using System.Runtime.CompilerServices;

namespace Ovning5.ui
{
    public class Menu_Main : IMenu
    {
        public IMenu interact(IUI ui, IHandler handler)
        {
            switch (ui.askForIntInput("Choose an option"))
            {
                case GlobalConstants.MenuOptionListType:
                    return this;
                    break;
                case GlobalConstants.MenuOptionFindByRegistation:
                    return this;
                    break;
                case GlobalConstants.MenuOptionListAllParked:
                    return this;
                    break;
                case GlobalConstants.MenuOptionSeed:
                    return this;
                    break;
                case GlobalConstants.MenuOptionQuit:
                    return null;
                    break;
                default:
                    return this;
                    break;
            }

        }

        public void print()
        {
            Console.WriteLine($"{GlobalConstants.MenuOptionListAllParked} List all parked vehicles");
            Console.WriteLine($"{GlobalConstants.MenuOptionListType} List vehicletypes");
            Console.WriteLine($"{GlobalConstants.MenuOptionSeed} Seed database");
            Console.WriteLine($"{GlobalConstants.MenuOptionFindByRegistation} Find car by registration");
            Console.WriteLine($"{GlobalConstants.MenuOptionQuit} Quit");
        }
    }
}