using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();


            int Cont = 1;
            do
            {

                Console.WriteLine("Hello! \nWhat do you want to do?");
                Console.WriteLine("(1) - Add new member");
                Console.WriteLine("(2) - Remove a member");
                Console.WriteLine("(3) - Add new product to the store");
                int menyVal = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (menyVal)
                {
                    case 1:
                        AddWho();
                        Console.Clear();
                        break;

                    case 2:
                        RemoveWho();
                        Console.Clear();
                        break;

                    case 3:
                        subject.Inventory++;
                        break;

                    case 4:
                        Cont = 0;
                        break;

                    default:
                        break;
                }
            } while (Cont == 1);

            void AddWho()
            {
                Console.WriteLine("What is the member's name? ");
                String memberName = Console.ReadLine();
                Observer member = new Observer(memberName);
                subject.BecomeMember(member);
            }

            void RemoveWho()
            {
                int nummer = 0;

                foreach (var member in subject.Members)
                {
                    nummer++;
                    Console.WriteLine("(" + nummer + ")" + member.ObserverName);
                }

                Console.WriteLine("Who do you want to remove?");
                int removeWho = Convert.ToInt32(Console.ReadLine());

                subject.RemoveMember(subject.Members[removeWho - 1]);
            }

        }
    }
}