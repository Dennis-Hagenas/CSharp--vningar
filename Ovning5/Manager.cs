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
            {
                Console.WriteLine("Welcome to GarageApp!");
                int newGarageSize = ui.askForIntInput("Please enter the number of parking spaces in the garage");
                handler.createGarage(newGarageSize);
            }
            {
                string answer = ui.askForStringInput("Do you want to seed the garage with a set of 10 vehicles(y/n)");
                if (answer.ToLower().Equals("y"))
                {
                    Menu_GarageMaintenance.seed(handler);
                }
            }
            while (ProgramIsRunning)
            {
                currentMenu.print();
                currentMenu = currentMenu.interact(ui, handler);
                if (currentMenu == null) ProgramIsRunning = false;
            }
        }
    }

}
