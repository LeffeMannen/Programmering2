using System;

namespace Listor_och_Arrayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett namn:");
            
            string[] namn = new string[5];
            for (int i = 0; i < namn.Length; i++)
            {
                namn[i] = Console.ReadLine();
                Console.WriteLine("Skriv ett till namn:");
            }
            Array.Reverse(namn);
            Console.WriteLine();
            Console.WriteLine("Namn i reverse ordning:");
            for (int i = 0; i < 5; i++)
            {
                
                Console.WriteLine(namn[i]);
            }
        }
    }
}
