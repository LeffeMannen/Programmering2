using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses
{
    class Pig : Animal
    {
        public Pig()
        {
            limbs = 4;
        }

        public override void Eat()
        {
            Console.WriteLine("Pig eats");
        }
        public override void Sleep()
        {
            Console.WriteLine("Pig sleeps");
        }
        public override void Poop()
        {
            Console.WriteLine("Pig poops");
        }
    }
}
