using Ovning5.garage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    return this;
                    break;
                case 2:
                    model = ui.askForStringInput("Enter model");
                    return this;
                    break;
                case 3:
                    color = ui.askForStringInput("Enter color");
                    return this;
                    break;
                case 4:
                    hjul = ui.askForIntInput("Enter nr of wheels");
                    return this;
                    break;
                case 5:
                    regnummer = ui.askForStringInput("Enter registration");
                    return this;
                    break;
                case 6:
                    vehicle = "Car";
                    model = "";
                    color = "";
                    hjul = 0;
                    regnummer = "";
                    return this;
                    break;
                case 10:
                    search(ui, handler);
                    return this;
                    break;

                case 11:
                    return menu_Search;
                    break;
                default:
                    return this;
                    break;
            }

        }


        string vehicle = "Car";
        string model = "";
        string color = "";
        int hjul = 0;
        string regnummer = "";


        public void print()
        {
            Console.WriteLine("Park a new vehicle (field with zero/blank will not be used)");
            Console.WriteLine($"1. Type {vehicle}");
            Console.WriteLine($"2. Model {model}");
            Console.WriteLine($"3. Color {color}");
            Console.WriteLine($"4. Antal hjul {hjul}");
            Console.WriteLine($"5. Registration number {regnummer}");
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
            if (hjul != 0)
                query = query.Where(s => s.NrOfWheels == hjul);
            if (!regnummer.Equals(""))
                query = query.Where(s => s.Registration.Equals(regnummer.ToUpper()));

            var result = query.ToList();
            foreach (Vehicle s in result)
                Menu_Search.printVehicle(s);
            Console.WriteLine();
        }
    }
}
