using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_FUNCTION
{
    class Bike
    {
        public string name;
        public string model;
        public int CHno;
    }


   /* class Dog
    {
        public string Name;
        public int age;

        public void bhaww ()
        {
            Console.WriteLine($"{Name} say bhawww");
        }
    }
   */
    class program
    {
        static void Main(string[] args)
        {
           /* Dog myDog = new Dog();
            myDog.Name = "kutta";
            myDog.age = 15;
            myDog.bhaww();

            Console.WriteLine($"my dog name is {myDog.Name} and his age is {myDog.age} year");
            Console.ReadLine();*/
            Bike myBike = new Bike();
            myBike.name = "kawasaki ninja H2r";
            myBike.model = "2024";
            myBike.CHno = 907658654;

            Console.WriteLine($"my bike  name is {myBike.name} and his model is {myBike.model} and {myBike.CHno}");
            Console.ReadLine();
        }
        

    }
}

