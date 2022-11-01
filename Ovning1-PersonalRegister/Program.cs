namespace Ovning1_PersonalRegister
{


    /*
     * Uppgift 1: Vilka klasser bör ingå?
     * 
     * 
     * klass :Employee
     * 
     * 
     * klass :MainDB
     * 
     * 
     * 
     * Uppgift 2: Vilka attribut och metoder bör ingå?
     * 
     * klass  :Employee
     * int salary
     * string name
     * 
     * 
     * klass  :MainDB
     * 
     * List<Employee>   EmployeeList 
     * 
     * add employee
     * get employee
     * set employee value
     * 
     */


    class Employee
    {
        public Employee() { }
        public Employee(string name, long salary)
        {
            this.Name = name;
            this.salary = salary;
        }

        public string Name;
        public long salary;

    }

    class MainDB
    {
        public MainDB()
        {
            employees = new List<Employee>();
        }
        public List<Employee> employees;

        public void AddEmployee(string name, long salary)
        {
            employees.Add(new Employee(name, salary));
        }


    }


    internal class Program
    {
        static void Main(string[] args)
        {


            MainDB mainDB = new MainDB();

            Console.WriteLine("Välkommen till PersonalRegister\n");


            int run = 1;
            while (run != 0)
            {

                Console.WriteLine("Meny");
                Console.WriteLine("1.Lägg till Personal");
                Console.WriteLine("3. Skriv ut all personal");
                Console.WriteLine("99. Avsluta");
                Console.Write(">");
                string menyInput = Console.ReadLine();
                Console.WriteLine("");


                switch (menyInput)
                {
                    case "1":
                        Console.WriteLine("Ange personens namn");
                        string name = Console.ReadLine();
                        Console.WriteLine("Ange personens lön");
                        long salary = long.Parse(Console.ReadLine());
                        mainDB.AddEmployee(name, salary);
                        break;
                    case "3":
                        Console.WriteLine("Personer");
                        Console.WriteLine("---------");

                        foreach (var e in mainDB.employees)
                        {
                            Console.WriteLine("- {0}  Lön:  {1:C}", e.Name, e.salary);
                        }
                        Console.WriteLine("");

                        break;
                    case "99":
                        run = 0;
                        break;
                    default:
                        break;
                }

            }
        }
    }
}