using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses
{
    class Cat : Animal
    {
        public Cat()
        {
            limbs = 4;
        }

        public override void Eat()
        {
            Console.WriteLine("Cat eats");
        }
        public override void Sleep()
        {
            Console.WriteLine("Cat sleeps");
        }
        public override void Poop()
        {
            Console.WriteLine("Cat poops");
        }

    }
}
