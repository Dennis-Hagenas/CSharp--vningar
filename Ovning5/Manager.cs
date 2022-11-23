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
        public IUI UI { get; }
        public IHandler handler { get; }
        public bool ProgramIsRunning { get; set; }

        public Manager()
        {
            UI = new UI();
            handler = new Handler();
        }

        public void run()
        {
            while (ProgramIsRunning)
            {
                UI.HandleInteractions();
            }
        }
    }
}
