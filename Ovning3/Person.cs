using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{

	

	public class Person
    {




		private int age;
		private string lName;
		private string fName;
		private double height;
		private double weight;



		public Person(string fName, string lName)
		{
			FName = fName;
			LName = lName;
		}




		public int Age
		{
			get { return age; }
			set {
				if (value > 0) age = value;
                else throw new ArgumentException("Invalid age");
				  }
		}


		public string LName
		{
			get { return lName; }
			set { if ((value.Length >= 3) || (value.Length <= 15))
					lName = value;
				else throw new ArgumentException("Invalid lastname");
			}
		}


		public string FName
		{
			get { return fName; }
            set
            {
                if ((value.Length >= 2) || (value.Length <= 10))
                    lName = value;
                else throw new ArgumentException("Invalid firstname");
            }
        }


        public double Height
		{
			get { return height; }
			set { height = value; }
		}




		public double Weight
		{
			get { return weight; }
			set { weight = value; }
		}


	}
}
