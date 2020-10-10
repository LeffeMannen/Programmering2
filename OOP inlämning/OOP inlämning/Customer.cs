using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_inlämning
{
        class Customer
        {
            private string _name;
           
            public string Name
            {
                get { return _name; }
                set { string _name = value; }
            }

            public Customer(string name)
            {
                _name = name;
               
            }
        }
    }