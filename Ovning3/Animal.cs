using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
/*
 * 
 * F: Om vi ska lägga till egenskaper till fåglar bör det läggas i klassen Bird
 * 
 * F: Om alla djur behöver ett nytt attribut bör det läggas i klassen Animal
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 */
    interface IPerson
    {
        public string Talk();
    }
    public abstract class Animal
    {
        public string Name { get; set; }

        public double Weight { get; set; }

        public double Age { get; set; }

        public abstract string DoSound();

        public virtual string Stats()
        {
            return "Name: "+ Name + ", Weight: " + Weight + ", Age: " + Age;
        }

        protected Animal(string name, double weight, double age)
        {
            Name = name;
            Weight = weight;
            Age = age;
        }
    }


    class Horse : Animal
    {
        public Horse(string name, double weight, double age) : base(name, weight, age)
        {
        }

        public override string Stats()
        {
            return base.Stats() + ", Sound: " + DoSound();
        }

        public override string DoSound()
        {
            return "Nyaaaah";
        }
        public bool IsRacingHorse { get; set; }
    }
    class Dog : Animal
    {
        public Dog(string name, double weight, double age) : base(name, weight, age)
        {
        }
        public override string Stats()
        {
            return base.Stats() + ", Sound: " + DoSound();
        }

        public override string DoSound()
        {
            return "Woooof";
        }

        public string FetchBall()
        {
            return "Ball";
        }

        public bool IsGuardDog { get; set; }
    }
    class Hedgehog : Animal
    {
        public Hedgehog(string name, double weight, double age) : base(name, weight, age)
        {
        }
        public override string Stats()
        {
            return base.Stats() + ", Sound: " + DoSound();
        }

        public override string DoSound()
        {
            return "Squeeek";
        }
        public int NrOfSpikes { get; set; }
    }
    class Worm : Animal
    {
        public Worm(string name, double weight, double age) : base(name, weight, age)
        {
        }
        public override string Stats()
        {
            return base.Stats() + ", Sound: " + DoSound();
        }

        public override string DoSound()
        {
            return "Squirm";
        }
        public bool IsPoisonous { get; set; }
    }
    class Bird : Animal
    {
        public Bird(string name, double weight, double age) : base(name, weight, age)
        {
        }
        public override string Stats()
        {
            return base.Stats() + ", Sound: " + DoSound();
        }

        public override string DoSound()
        {
            return "Pip pip";
        }
        public double WingSpan { get; set; }
    }
    class Wolf : Animal
    {
        public Wolf(string name, double weight, double age) : base(name, weight, age)
        {
        }
        public override string Stats()
        {
            return base.Stats() + ", Sound: " + DoSound();
        }

        public override string DoSound()
        {
            return "Yyyyl";
        }
        public bool IsArctic { get; set; }
    }


    class Pelican : Bird
    {
        public Pelican(string name, double weight, double age) : base(name, weight, age)
        {
        }
    }


    class Flamingo : Bird
    {
        public Flamingo(string name, double weight, double age) : base(name, weight, age)
        {
        }
    }


    class Swan : Bird
    {
        public Swan(string name, double weight, double age) : base(name, weight, age)
        {
        }
    }

    class WolfMan : Wolf, IPerson
    {
        public WolfMan(string name, double weight, double age) : base(name, weight, age)
        {
        }

        public string Talk()
        {
            return "Hello, I am a WolfMan";
        }
    }

}
