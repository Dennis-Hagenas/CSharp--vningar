using Ovning5.garage;

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
                    create(ui, handler);
                    return this;
                case GlobalConstants.MenuOptionRemoveVehicle:
                    remove(ui, handler);
                    return this;
                case GlobalConstants.MenuOptionReturn:
                    return menu_Main;
                default:
                    return this;
            }
        }
        private static void remove(IUI ui, IHandler handler)
        {
            string reg = ui.askForStringInput("Enter registration number");
            Vehicle result = handler.remove(reg);
            if (result != null)
            {
                Console.WriteLine("Successfully removed");
                Menu_Search.printHeader();
                Menu_Search.printVehicle(result);
            }
            else
                Console.WriteLine("Vehicle is not in garage");
        }
        public void print()
        {
            Console.WriteLine("[-----------Parking--Menu----------------------]");
            Console.WriteLine($"{GlobalConstants.MenuOptionPark} Park vehicle");
            Console.WriteLine($"{GlobalConstants.MenuOptionRemoveVehicle} Remove vehicle");
            Console.WriteLine($"{GlobalConstants.MenuOptionReturn} Return to main menu");
        }
        private void create(IUI ui, IHandler handler)
        {
            if(handler.getFreeParkingSpace()< 1)
            {
                Console.WriteLine("No more free parking spaces\n");
                return;
            }
            string model = ui.askForStringInput("Enter model");
            string color = ui.askForStringInput("Enter color");
            int nrWheels = ui.askForIntInput("Enter nr of wheels");
            string regNumber = ui.askForStringInput("Enter registration number");

            int type = ui.askForIntInput("Enter type (Airplane: 1, Boat: 2, Bus: 3, Car: 4, Motorcycle: 5)");
            Vehicle result = null!;
            switch (type)
            {
                case 1:
                    int seats = ui.askForIntInput("Enter nr of seats");
                    result = handler.parkVehicle(new Airplane(model, color, nrWheels, regNumber, seats));
                    break;
                case 2:
                    int length = ui.askForIntInput("Enter length");
                    result = handler.parkVehicle(new Boat(model, color, nrWheels, regNumber, length));
                    break;
                case 3:
                    string fuelType = ui.askForStringInput("Enter fueltype");
                    result = handler.parkVehicle(new Bus(model, color, nrWheels, regNumber, fuelType));
                    break;
                case 4:
                    int year = ui.askForIntInput("Enter year");
                    result = handler.parkVehicle(new Car(model, color, nrWheels, regNumber, year));
                    break;
                case 5:
                    int cylinderVolume = ui.askForIntInput("Enter cylinder volume");
                    result = handler.parkVehicle(new Motorcycle(model, color, nrWheels, regNumber, cylinderVolume));
                    break;
                default:
                    break;
            }
            if (result != null)
            {
                Console.WriteLine("Successfully added");
                Menu_Search.printHeader();
                Menu_Search.printVehicle(result);
                Console.WriteLine();
            }
            else
                Console.WriteLine("Could not add vehicle");
        }
    }
}
