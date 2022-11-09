using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    public class PersonHandler
    {
        public void setAge(Person person, int age)
        {
            person.Age = age;
        }

        public Person CreatePerson(int age, string fName, string lName, double height, double weight)
        {
            Person p = new Person(fName, lName);
            setAge(p, age);
            p.Height = height;
            p.Weight = weight;
            return p;

        }
    }
}
