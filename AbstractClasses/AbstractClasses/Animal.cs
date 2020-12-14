using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses
{
    abstract class Animal
    {
        public string Color { get; set; }

        public int limbs { get; set; }

        public abstract void Eat();

        public abstract void Sleep();

        public abstract void Poop();
    }
}
