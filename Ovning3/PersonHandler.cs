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
        public void setFName(Person person, string fName)
        {
            person.FName = fName;
        }
        public void setLName(Person person, string lName)
        {
            person.LName = lName;
        }

        public void setHeight(Person person, double height)
        {
            person.Height = height;
        }

        public void setWeight(Person person, double weight)
        {
            person.Weight = weight;
        }

        public Person CreatePerson(int age, string fName, string lName, double height, double weight)
        {
            Person p = new Person(fName, lName);
            setAge(p, age);
            setHeight(p, height);
            setWeight(p, weight);
            return p;
        }
    }
}
