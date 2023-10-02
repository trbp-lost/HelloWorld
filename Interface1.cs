using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    interface IPrey
    {
        void Flee();
    }

    interface IPredator
    {
        void Hunt();
    }

    class Rabbit : IPrey
    {
        public void Flee()
        {
            Console.WriteLine("The rabbit runs away");
        }
    }

    class Hawk : IPredator
    {
        public void Hunt()
        {
            Console.WriteLine("The hawk goes hunt");
        }
    }

    class Fish : IPrey, IPredator
    {
        public void Flee()
        {
            Console.WriteLine("The fish runs away");
        }

        public void Hunt()
        {
            Console.WriteLine("The fish goes hunt");
        }
    }
}
