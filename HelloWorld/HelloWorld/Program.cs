using System;
using System.Linq.Expressions;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Niklas!");

            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            if (name.ToUpper() == "ANDREAS"){
                Console.WriteLine("eyyyy coolt namn");
            }
            else
            {
                Console.WriteLine("Synd att du inte heter Andreas :(");
            }

            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter your age " + (3-i) +" more times:" );
                
                while (true){
                    int age1 = Convert.ToInt32(Console.ReadLine());
                    if (age1 == age){
                        break;
                    }
                    Console.WriteLine("Kan du bestäma dig eller?");
                }
            }

            var hello = true;
            while (true)
            {
                Console.WriteLine("(Gabriel Billskog sover för lite)");
                break;
            }

            Console.WriteLine("Are you alive?");
            string alive = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Your name is " + name + "\nYour are " + age + " years old \nAlive? = " + alive);

            Console.WriteLine("Tryck på (1) om du tyckte det var kul att trycka på knappar hehe :)");
            Console.WriteLine("Tryck på (2) om du inte tyckte att det var kul att trycka på knappar :(");
            var game = Convert.ToInt32(Console.ReadLine());

            switch (game){
                case 1:
                    Console.WriteLine("k bror\n\n\n\nC \n\nR \n\nI \n\nN \n\nG \n\nE \n\n\n\n");
                    break;
                case 2:
                    Console.WriteLine("k bror wrong opinion\n\n\n\nC \n\nR \n\nI \n\nN \n\nG \n\nE \n\n\n\n");
                    break;
                default:
                    Console.WriteLine("Du tryckte varken 1 eller 2 mannem..... \n\n\n\nC \n\nR \n\nI \n\nN \n\nG \n\nE \n\n\n\n");
                    break;
            }

        }
    }
}
