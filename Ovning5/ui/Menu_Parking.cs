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
            if (result != null) Console.WriteLine(
                    $"Succesfully removed\n{result.Model,-25}|{result.Color,10}|{result.NrOfWheels,10}|{result.Registration,10}");
            else
                Console.WriteLine("Vehicle is not in garage");
        }

        public void print()
        {
            Console.WriteLine("[------------Park----Vehicle-------------]");
            Console.WriteLine($"{GlobalConstants.MenuOptionPark} Park vehicle");
            Console.WriteLine($"{GlobalConstants.MenuOptionRemoveVehicle} Remove vehicle");
            Console.WriteLine($"{GlobalConstants.MenuOptionReturn} Return to main menu");
        }
        private void create(IUI ui, IHandler handler)
        {
            string model = ui.askForStringInput("Enter model");
            string color = ui.askForStringInput("Enter color");
            int nrWheels = ui.askForIntInput("Enter nr of wheels");
            string regNumber = ui.askForStringInput("Enter registration number");

            int type = ui.askForIntInput("Enter type (Airplane: 1, Boat: 2, Bus: 3, Car: 4, Motorcycle: 5)");
            Vehicle result;
            switch (type)
            {
                case 1:
                    int seats = ui.askForIntInput("Enter nr of seats");
                    result = handler.parkVehicle(new Airplane(model, color, nrWheels, regNumber, seats));
                    if (result != null)
                    {
                        Console.WriteLine("Succesfully added new airplane");
                        Menu_Search.printVehicle(result);
                    }
                    else Console.WriteLine("Could not add vehicle");
                    break;
                case 2:
                    int length = ui.askForIntInput("Enter length");
                    result = handler.parkVehicle(new Boat(model, color, nrWheels, regNumber, length));
                    if (result != null)
                    {
                        Console.WriteLine("Succesfully added new boat");
                        Menu_Search.printVehicle(result);
                    }
                    else Console.WriteLine("Could not add vehicle");
                    break;
                case 3:
                    string fuelType = ui.askForStringInput("Enter fueltype");
                    result = handler.parkVehicle(new Bus(model, color, nrWheels, regNumber, fuelType));
                    if (result != null)
                    {
                        Console.WriteLine("Succesfully added new bus");
                        Menu_Search.printVehicle(result);
                    }
                    else Console.WriteLine("Could not add vehicle");
                    break;
                case 4:
                    int year = ui.askForIntInput("Enter year");
                    result = handler.parkVehicle(new Car(model, color, nrWheels, regNumber, year));
                    if (result != null)
                    {
                        Console.WriteLine("Succesfully added new car");
                        Menu_Search.printVehicle(result);
                    }
                    else Console.WriteLine("Could not add vehicle");
                    break;
                case 5:
                    int cylinderVolume = ui.askForIntInput("Enter cylinder volume");
                    result = handler.parkVehicle(new Motorcycle(model, color, nrWheels, regNumber, cylinderVolume));
                    if (result != null)
                    {
                        Console.WriteLine("Succesfully added new motorcycle");
                        Menu_Search.printVehicle(result);
                    }
                    else Console.WriteLine("Could not add vehicle");
                    break;
                default:
                    break;
            }
        }
    }
}
