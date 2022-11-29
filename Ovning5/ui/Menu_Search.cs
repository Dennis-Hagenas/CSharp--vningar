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
                case GlobalConstants.MenuOptionListVehicleTypes:
                    listTypes(handler);
                    return this;
                case GlobalConstants.MenuOptionListByField:
                    return new Menu_ListByField(this);
                case GlobalConstants.MenuOptionFindByRegistation:
                    findRegistration(ui, handler);
                    return this;
                case GlobalConstants.MenuOptionReturn:
                    return menu_Main;
                default:
                    return this;
            }
        }

        private void listTypes(IHandler handler)
        {
            int airplane = 0, boat = 0, bus = 0, car = 0, motorcycle = 0;

            foreach (Vehicle f in handler)
            {
                if (f is Car) car++;
                if (f is Airplane) airplane++;
                if (f is Boat) boat++;
                if (f is Motorcycle) motorcycle++;
                if (f is Bus) bus++;
            }
            Console.WriteLine($"\nVehicle types in garage\nCars: {car}\n" +
                $"Airplane: {airplane}\nBoat: {boat}\nMotorcycle: {motorcycle}\n" +
                $"Bus: {bus}\n\n");

        }

        private void findRegistration(IUI ui, IHandler handler)
        {
            Console.WriteLine();
            string query = ui.askForStringInput("Enter registration");
            var result = from s in handler where s.Registration.Equals(query.ToUpper()) select s;
            foreach (Vehicle s in result)
                printVehicle(s);
            Console.WriteLine();
        }

        private static void listAll(IHandler handler)
        {
            Console.WriteLine($"Model                        Color     Wheels    Registration      Type");
            Console.WriteLine($"-----------------------------------------------------------------------");

            foreach (Vehicle vehicle in handler)
            {
                printVehicle(vehicle);
            }
            Console.WriteLine();
        }

        public static void printVehicle(Vehicle vehicle)
        {
            string type = "";
            {
                if (vehicle is Car) type = "car";
                if (vehicle is Airplane) type = "airplane";
                if (vehicle is Boat) type = "boat";
                if (vehicle is Motorcycle) type = "motorcycle";
                if (vehicle is Bus) type = "bus";
            }

            Console.WriteLine(
                $"{vehicle.Model,-25}|{vehicle.Color,10}|{vehicle.NrOfWheels,10}|{vehicle.Registration,10}|{type,12}");
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
