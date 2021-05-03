using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class Subject : ISubject
    {
        public List<Observer> Members = new List<Observer>();
        private int _int;

        public int Inventory
        {
            get
            {
                return _int;
            }
            set
            {
                if (value > _int)
                {
                    Notify();
                }
                _int = value;
            }
        }

        public void BecomeMember(Observer observer)
        {
            Members.Add(observer);
        }

        public void RemoveMember(Observer observer)
        {
            Members.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in Members)
            {
                observer.Update();
            }
        }
    }
}