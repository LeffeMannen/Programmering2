using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses
{
    class Leash : Accessories
    {
        public Leash()
        {
            Price = 20;
            Console.WriteLine("What size do you want your leash to be?");
            Size = Console.ReadLine();
        }
        public override void Break()
        {
            Console.WriteLine("The leash broke");
        }

        public override void Clean()
        {
            Console.WriteLine("The leash is clean");
        }
    }
}
