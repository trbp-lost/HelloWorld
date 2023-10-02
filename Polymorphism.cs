using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
   abstract class Polymorphism
    {
        abstract public void Go(); //bisa pakai virtual jg
    }

    class Car3 : Polymorphism
    {
        public override void Go()
        {
            Console.WriteLine("Car is moving");
        }
    }

    class Bicycle : Polymorphism
    {
        public override void Go()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    class Boat : Polymorphism
    {
        public override void Go()
        {
            Console.WriteLine("Boat is moving");
        }
    }
}
