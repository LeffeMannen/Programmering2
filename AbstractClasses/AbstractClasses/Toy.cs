using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses
{
    class Toy: Accessories
    {
        public Toy()
        {
            Price = 30;
            Console.WriteLine("What toy size do you want?");
            Size = Console.ReadLine();
        }
        public override void Break()
        {
            Console.WriteLine("The toy broke");
        }

        public override void Clean()
        {
            Console.WriteLine("The toy is clean");
        }
    }
}
