using Ovning5.garage;

namespace Ovning5.ui
{
    public class Menu_ListByField : IMenu
    {
        private Menu_Search menu_Search;
        public Menu_ListByField(Menu_Search menu_Search)
        {
            this.menu_Search = menu_Search;
        }
        public IMenu interact(IUI ui, IHandler handler)
        {
            switch (ui.askForIntInput("Choose an option"))
            {
                case 1:
                    type = ui.askForStringInput("Enter type(Airplane, Boat, Bus, Car, Motorcycle are valid)");
                    return this;
                case 2:
                    model = ui.askForStringInput("Enter model");
                    return this;
                case 3:
                    color = ui.askForStringInput("Enter color");
                    return this;
                case 4:
                    wheels = ui.askForIntInput("Enter nr of wheels");
                    return this;
                case 5:
                    registration = ui.askForStringInput("Enter registration");
                    return this;
                case 6:
                    type = "";
                    model = "";
                    color = "";
                    wheels = 0;
                    registration = "";
                    return this;
                case 10:
                    search(ui, handler);
                    return this;
                case 11:
                    return menu_Search;
                default:
                    return this;
            }
        }


        string type = "";
        string model = "";
        string color = "";
        int wheels = 0;
        string registration = "";


        public void print()
        {
            Console.WriteLine("[-------------Search--by--field----------------]");
            Console.WriteLine("Park a new vehicle (field with zero/blank will not be used)");
            Console.WriteLine($"1. Type                 :{type}");
            Console.WriteLine($"2. Model                :{model}");
            Console.WriteLine($"3. Color                :{color}");
            Console.WriteLine($"4. Antal hjul           :{wheels}");
            Console.WriteLine($"5. Registration number  :{registration}");
            Console.WriteLine($"6. Reset");
            Console.WriteLine($"10. Search");
            Console.WriteLine($"11. Back to search menu");
        }

        private void search(IUI ui, IHandler handler)
        {
            Console.WriteLine();
            var query = from s in handler select s;

            if (!model.Equals(""))
                query = query.Where(s => s.Model.Equals(model));
            if (!color.Equals(""))
                query = query.Where(s => s.Color.Equals(color));
            if (wheels != 0)
                query = query.Where(s => s.NrOfWheels == wheels);
            if (!registration.Equals(""))
                query = query.Where(s => s.Registration.Equals(registration.ToUpper()));
            if (type.ToLower().Equals("airplane")) query = query.Where(s => (s is Airplane));
            if (type.ToLower().Equals("boat")) query = query.Where(s => (s is Boat));
            if (type.ToLower().Equals("bus")) query = query.Where(s => (s is Bus));
            if (type.ToLower().Equals("car")) query = query.Where(s => (s is Car));
            if (type.ToLower().Equals("motorcycle")) query = query.Where(s => (s is Motorcycle));

            var result = query.ToList();
            Console.WriteLine("Results:");
            Menu_Search.printHeader();
            foreach (Vehicle s in result)
                Menu_Search.printVehicle(s);
            Console.WriteLine();
        }
    }
}
