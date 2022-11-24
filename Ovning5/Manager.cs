using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ovning5.ui;

namespace Ovning5
{
    public class Manager
    {
        public IUI ui { get; }
        public IHandler handler { get; }
        public bool ProgramIsRunning { get; set; }

        public Manager()
        {
            ui = new UI();
            handler = new Handler();
            ProgramIsRunning = true;
        }

        public void run()
        {
            IMenu currentMenu = new Menu_Main();
            while (ProgramIsRunning)
            {
                currentMenu.print();
                currentMenu = currentMenu.interact(ui, handler);
                if (currentMenu == null) ProgramIsRunning = false;
            }
        }
    }

}
