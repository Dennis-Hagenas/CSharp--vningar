using System.Text;

namespace OOP_Inheritance_Exercise
{



    public class Person
    {
        protected String name;
        protected int age;
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public virtual String Name
        {
            get { return name; }
            set
            {
                if (value.Length < 3)
                    throw new ArgumentException("Name's length should not be less than 3 symbols!");
                name = value;
            }
        }
        public virtual int Age
        {
            get { return age; }
            set
            {
                if (value < 0) throw new ArgumentException("Age must be positive!");
                age = value;
            }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(String.Format("Name: {0}, Age: {1}", this.Name, this.Age));
            return stringBuilder.ToString();
        }
    }
    internal class Child : Person
    {
        public Child(string name, int age) : base(name, age)
        {
            Name = name;
            Age = age;
        }
        public override string Name { get => base.Name; set => base.Name = value; }
        public override int Age
        {
            get => base.Age;
            set
            {
                if (value > 15) throw new ArgumentException("Child's age must be less than 15!");
                base.Age = value;
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            try
            {
                Child child = new Child(name, age);
                Console.WriteLine(child);
            }
            catch (ArgumentException ae) { Console.WriteLine(ae.Message); }
        }
    }

}