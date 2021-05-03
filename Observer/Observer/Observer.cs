using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class Observer : IObserver
    {
        public string ObserverName { get; private set; }

        public Observer(string name)
        {
            ObserverName = name;
        }

        public void Update()
        {
            Console.WriteLine(ObserverName + " A new product is availible in the store!");
        }

    }
}