namespace Ovning3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    Person person = new Person("Kalle", "Persson");
            //    // Jag kommer direkt åt variablen med överladdad setter
            //    person.Age = 45;
            //} catch (ArgumentException ex)  
            //{
            //    Console.WriteLine("Felaktigt argument: " + ex.Message);
            //}

            PersonHandler personHandler = new PersonHandler();

            Person p1 = personHandler.CreatePerson(35, "Kalle", "Person", 1.90, 92);
            Person p2 = personHandler.CreatePerson(28, "Anna", "Gustavsson", 1.78, 65);
            Person p3 = personHandler.CreatePerson(42, "Felix", "Nilsson", 1.89, 79);
            Person p4 = personHandler.CreatePerson(39, "Muhammed", "Bengtson", 1.78, 91);
            Person p5 = personHandler.CreatePerson(48, "Bruce", "Campbell", 1.75, 85);


            List<UserError> errors = new List<UserError>();
            errors.Add(new NumericInputError());
            errors.Add(new TextInputError());
            errors.Add(new NumericSignInputError());
            errors.Add(new TextInputError());
            errors.Add(new NumericSignInputError());
            errors.Add(new NumericSignInputError());
            errors.Add(new NumericInputError());
            errors.Add(new NumericInputError());
            errors.Add(new TextInputError());
            errors.Add(new TextLengthInputError());
            errors.Add(new NumericSignInputError());
            errors.Add(new NumericRangeInputError());
            errors.Add(new TextLengthInputError());
            errors.Add(new NumericSignInputError());
            errors.Add(new NumericRangeInputError());
            errors.Add(new TextLengthInputError());
            errors.Add(new NumericRangeInputError());
            errors.Add(new TextLengthInputError());
            errors.Add(new NumericRangeInputError());
            errors.Add(new TextLengthInputError());
            errors.Add(new TextInputError());
            errors.Add(new NumericSignInputError());
            errors.Add(new NumericRangeInputError());
            errors.Add(new TextInputError());
            errors.Add(new TextLengthInputError());
            errors.Add(new NumericInputError());
            errors.Add(new NumericRangeInputError());


            foreach (UserError error in errors)
                Console.WriteLine($"Error: {error.UEMessage()}");





            List<Animal> animals = new List<Animal>();

            animals.Add(new Wolf("Wolf", 15, 5));
            animals.Add(new Pelican("Pelican", 15, 5));
            animals.Add(new Bird("Bird", 15, 5));
            animals.Add(new WolfMan("WolfMan", 15, 5));
            animals.Add(new Dog("Dog", 15, 5));

            Console.WriteLine("\nAnimals\n-------------\n");

            foreach (Animal animal in animals)
            {
                Console.WriteLine($"Animal: {animal.Name}  Sound: {animal.DoSound()}");
                if (animal is IPerson)
                {
                    IPerson person = (IPerson)animal;
                    Console.WriteLine(person.Talk());
                }
            }




            List<Dog> dogs = new List<Dog>();

            dogs.Add(new Dog("Dog", 15, 5));
            dogs.Add(new Dog("Dog", 15, 5));
            dogs.Add(new Dog("Dog", 15, 5));
            dogs.Add(new Dog("Dog", 15, 5));
            dogs.Add(new Dog("Dog", 15, 5));

            Console.WriteLine("\nDogs\n-------------\n");
            foreach (Dog dog in dogs)
            {
                Console.WriteLine(dog.Stats());
            }

            //dogs.Add(new Horse("Horse", 180, 10));
            /*
             * F: Ovanstående går inte för det är inte samma klass typ
             * F: För att alla klasser ska kunna lagras tillsammans måste typen vara Animal i listan
             */


            Console.WriteLine("\nAnimals\n-------------\n");

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.Stats());
                if (animal is Dog)
                {
                    Dog dog = (Dog)animal;
                    Console.WriteLine($"Dog gives a: {dog.FetchBall()}");
                }

            }
            /*
             * F: Den överladdade versionen av doSound anropas i subclassen
             * F: FetchBall i Dog klassen kommer jag inte åt från Animal klassen för den är inte definerad där,
             *    Jag måste cast till Dog först
             * 
             */

        }
    }
}