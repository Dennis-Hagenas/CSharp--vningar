namespace EncapsulationLab
{
    internal class Program
    {


        internal class Person
        {
            public Person(string FirstName, string LastName, int age)
            {
                firstName = FirstName;
                lastName = LastName;
                this.age = age;
            }

            public string firstName { get; set; }
            public string lastName { get; set; }
            public int age { get; set; }

            public string ToString()
            {
                return $"{firstName} {lastName} is {age} years old.";
            }

        }


        public static void Main()
        {
            var lines = 5;
            var persons = new List<Person>();
            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2])); persons.Add(person);
            }
            persons.OrderBy(p => p.firstName)
                .ThenBy(p => p.age)
                .ToList()
                .ForEach(p => Console.WriteLine(p.ToString()));
        }
    }

}