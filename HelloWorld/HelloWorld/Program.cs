using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Niklas!");



            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();



            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Are you alive?");
            string alive = Console.ReadLine();


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Your name is " + name + "\nYour are " + age + " years old \nAlive? = " + alive);

        }
    }
}
