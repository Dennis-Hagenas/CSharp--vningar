using Ovning5.garage;

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
                    listAll(handler);
                    return this;
                    break;
                case GlobalConstants.MenuOptionListVehicleTypes:
                    listTypes(handler);
                    return this;
                    break;
                case GlobalConstants.MenuOptionListByField:
                    return new Menu_ListByField(this);
                    break;
                case GlobalConstants.MenuOptionFindByRegistation:
                    findRegistration(ui, handler);
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

        private void listTypes(IHandler handler)
        {

        }

        private void findRegistration(IUI ui, IHandler handler)
        {
        }

        private static void listAll(IHandler handler)
        {
            Console.WriteLine($"Model                        Color     Wheels    Registration");
            Console.WriteLine($"-------------------------------------------------------------");

            foreach (Vehicle vehicle in handler)
            {
                Console.WriteLine(
                    $"{vehicle.Model,-25}|{vehicle.Color,10}|{vehicle.NrOfWheels,10}|{vehicle.Registration,10}");
            }
            Console.WriteLine();
        }

        public void print()
        {
            Console.WriteLine("[------------Search---Garage------------------]");
            Console.WriteLine($"{GlobalConstants.MenuOptionListAllParked} List all parked");
            Console.WriteLine($"{GlobalConstants.MenuOptionListVehicleTypes} List vehicle type and amount");
            Console.WriteLine($"{GlobalConstants.MenuOptionFindByRegistation} Find by registration");
            Console.WriteLine($"{GlobalConstants.MenuOptionListByField} List by field");
            Console.WriteLine($"{GlobalConstants.MenuOptionReturn} Return to main menu");
        }
    }
}
