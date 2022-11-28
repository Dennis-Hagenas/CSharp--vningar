using Ovning5.garage;

namespace Ovning5.ui
{
    public class Menu_GarageMaintenance : IMenu
    {
        private Menu_Main menu_Main;

        public Menu_GarageMaintenance(Menu_Main menu_Main)
        {
            this.menu_Main = menu_Main;
        }

        public IMenu interact(IUI ui, IHandler handler)
        {
            switch (ui.askForIntInput("Choose an option"))
            {
                case GlobalConstants.MenuOptionSeed:
                    seed(handler);
                    return this;
                    break;
                case GlobalConstants.MenuOptionCreate:
                    Create(ui, handler);
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

        private void Create(IUI ui, IHandler handler)
        {
            int size = ui.askForIntInput("Enter new garage size (this will remove the old garage)");   
            handler.createGarage(size);
        }

        public static void seed(IHandler handler)
        {
            handler.parkVehicle(new Car("Volvo 740", "Blue", 4, "QWE564", 1984));
            handler.parkVehicle(new Car("MercedesBenz S90", "Red", 4, "Dfg384", 1972));
            handler.parkVehicle(new Car("Saab 95", "Grey", 4, "Aft485", 1998));
            handler.parkVehicle(new Car("Lamborghini Countach", "Red", 4, "kew394", 2004));
            handler.parkVehicle(new Car("Mazda Speedster", "Green", 4, "ode124", 2010));
            handler.parkVehicle(new Car("Volkswagen Bus", "White", 4, "isk523", 1990));
            handler.parkVehicle(new Car("BMW", "Blue", 4, "tkd264", 2018));
        }

        public void print()
        {
            Console.WriteLine("[----------Maintenance---Menu------------------]");
            Console.WriteLine($"{GlobalConstants.MenuOptionSeed} Seed garage with vehicles");
            Console.WriteLine($"{GlobalConstants.MenuOptionCreate} Create a new garage");
            Console.WriteLine($"{GlobalConstants.MenuOptionReturn} Return to main menu");
        }
    }
}
