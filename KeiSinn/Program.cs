using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeiSinn
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Animal");
            Animal a1 = new Animal();
            Animal a2 = new Dog();
            Animal a3 = new Beagle();
            Animal a4 = new AmericanBeagle();
            Animal a5 = new AmericanBigBeagle();

            a1.WhoAreYou();
            a2.WhoAreYou();
            a3.WhoAreYou();
            a4.WhoAreYou();
            a5.WhoAreYou();

            Console.WriteLine("");
            Console.WriteLine("Dog");
            Dog d1 = new Dog();
            Dog d2 = new Beagle();
            Dog d3 = new AmericanBeagle();
            Dog d4 = new AmericanBigBeagle();

            d1.WhoAreYou();
            d2.WhoAreYou();
            d3.WhoAreYou();
            d4.WhoAreYou();

            Console.WriteLine("");
            Console.WriteLine("Beagle");
            Beagle b1 = new Beagle();
            Beagle b2 = new AmericanBeagle();
            Beagle b3 = new AmericanBigBeagle();

            b1.WhoAreYou();
            b2.WhoAreYou();
            b3.WhoAreYou();

            Console.WriteLine("");
            Console.WriteLine("AmericanBeagle");
            AmericanBeagle ab1 = new AmericanBeagle();
            AmericanBeagle ab2 = new AmericanBigBeagle();

            ab1.WhoAreYou();
            ab2.WhoAreYou();

            Console.ReadKey();
        }
    }

    class Animal
    {
        public virtual void WhoAreYou() { Console.WriteLine("Animal"); }
    }
    class Dog : Animal
    {
        public override void WhoAreYou() { Console.WriteLine("Dog"); }
    }
    class Beagle : Dog
    {
        public new virtual void WhoAreYou() { Console.WriteLine("Beagle"); }
    }
    class AmericanBeagle : Beagle
    {
        public override void WhoAreYou() { Console.WriteLine("AmericanBeagle"); }
    }
    class AmericanBigBeagle : AmericanBeagle
    {
        public new virtual void WhoAreYou() { Console.WriteLine("AmericanBigBeagle"); }
    }

}
