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
                case GlobalConstants.MenuOptionParking:
                    return this;
                    break;

                case GlobalConstants.MenuOptionRemoveVehicle:
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

        public void print()
        {
            Console.WriteLine("Park a new vehicle");
            Console.WriteLine($"1. Type ");
            Console.WriteLine($"2. Model ");
            Console.WriteLine($"3.  ");
            Console.WriteLine($"4. Type ");
            Console.WriteLine($"10. Create vehicle ");
            Console.WriteLine($"11. Exit without saving ");
        }
    }
}
