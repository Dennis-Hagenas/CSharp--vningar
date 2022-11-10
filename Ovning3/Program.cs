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
        }
    }
}