using System;
using System.Threading;

namespace OOP_inlämning
{
    class Program
    {
        static void Main(string[] args)
        {

            string name;
            var buying = 0;

            Console.WriteLine("Type your name here:");
            name = Console.ReadLine();

            Customer customer = new Customer(name);
            Product cheese = new Product("Cheese", 45);
            Product bread = new Product("Bread", 18);
            Product butter = new Product("Butter", 12);

            Console.WriteLine("Welcome to this store " + customer.Name + "! What are you looking for to buy?\n" + cheese.Name + ", " + cheese.Cost + " kr\n" + bread.Name + ", " + bread.Cost + " kr\n" + butter.Name + ", " + butter.Cost + " kr");

            
                Console.WriteLine("How many " + cheese.Name + "s do you want to buy?");
                int Cheese = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nHow many " + bread.Name + "s do you want to buy?");
                int Bread = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nHow many " + butter.Name + "s do you want to buy?\n");
                int Butter = Convert.ToInt32(Console.ReadLine());

                buying = Cheese * cheese.Cost + Bread * bread.Cost + Butter * butter.Cost;
                Console.WriteLine("You are currently buying " + Cheese + " cheese, " + Bread + " bread and " + Butter + " butter\n\n");
                Console.WriteLine("That will be " + buying + " kr!");
                


            
            Console.WriteLine("Thank you for buying here, have a nice day!\n\nHope we see you another day :)");
        }
    }
}
