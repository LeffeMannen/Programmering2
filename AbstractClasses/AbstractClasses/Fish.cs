using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses
{
    class Fish : Animal
    {
        public Fish()
        {
            limbs = 0;
        }

        public override void Eat()
        {
            Console.WriteLine("Fish eats");
        }
        public override void Sleep()
        {
            Console.WriteLine("Fish sleeps");
        }
        public override void Poop()
        {
            Console.WriteLine("Fish poops");
        }
    }
}
