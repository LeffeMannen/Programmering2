using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorfi_Inlämning
{
    class Customer
    {
        private string _name;
        public List<Product> _cart = new List<Product>();

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Customer(string name)
        {
            _name = name;

        }
    }
}