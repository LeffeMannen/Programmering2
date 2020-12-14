using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses
{
    abstract class Accessories
    {
        public int Price { get; set; }

        public string Size { get; set; }

        public string Color { get; set; }

        public abstract void Clean();

        public abstract void Break();

    }
}
