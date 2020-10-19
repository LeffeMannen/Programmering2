using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace Polymorfi_Inlämning
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = string.Empty;
            Random random = new Random();

            Console.WriteLine("Type your name here:");
            name = Console.ReadLine();
            

            Customer kund = new Customer(name);
            bool shop = true;
            while (shop)
            {
                Console.WriteLine("Welcome to our store " + kund.Name + "!\nWe have every product you are looking for!\nDo you want to make a purchase?");
                if (Console.ReadLine().ToLower() == "yes")
                {
                    Console.WriteLine("What are you looking for to buy?");
                    var product = new Product() { _productName = Console.ReadLine() };
                    kund._cart.Add(product);
                    Console.WriteLine("How many " + product._productName + "s do you want to buy?");
                    var price = random.Next(20, 70);
                    Console.WriteLine("1 " + product._productName + " costs " + price + " kr");
                    Console.ReadLine();
                }
                else if (Console.ReadLine().ToLower() == "no")
                {
                    Environment.Exit(1);
                }
                else 
                    break;

                Console.WriteLine("do you want to buy anything else?");

                    if (Console.ReadLine().ToLower() == "yes")
                    {
                        Console.WriteLine("What do you want to buy?");
                        var product = new Product() { _productName = Console.ReadLine() };
                        kund._cart.Add(product);
                        Console.WriteLine("How many " + product._productName + "s do you want to buy?");
                        var price = random.Next(20, 70);
                        Console.WriteLine("1 " + product._productName + " costs " + price + " kr");
                        Console.ReadLine();
                    }
                    else if (Console.ReadLine().ToLower() == "no")
                    {
                        break;
                    }

                Console.WriteLine("Do you want to view your cart?");
                if (Console.ReadLine().ToLower() == "yes")
                {
                    Console.Clear();
                    Console.WriteLine("Viewing cart:\n");
                
                    foreach (var item in kund._cart)
                        Console.WriteLine(item._productName);
                    Console.WriteLine("\nThank you for buying here, have a nice day!\nHope we see you another day :)");
                }
                else
                    
                Console.WriteLine("\nThank you for buying here, have a nice day!\nHope we see you another day :)");
                shop = false;
            }
        }
    }
}