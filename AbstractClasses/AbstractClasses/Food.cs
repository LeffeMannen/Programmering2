using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses
{
    class Food : Accessories
    {
        public Food()
        {
            Price = 10;
            Console.WriteLine("How much food do you want?");
            Size = Console.ReadLine();
        }
        public override void Break()
        {
            Console.WriteLine("The food broke");
        }

        public override void Clean()
        {
            Console.WriteLine("The food is clean");
        }
    }
}
