using System;
using System.Collections.Generic;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            var pig = new Pig();
            pig.Color = "Blue";

            var cat = new Cat();
            cat.Color = "Black";

            var fish = new Fish();
            fish.Color = "Red";


            animals.Add(pig);
            animals.Add(cat);
            animals.Add(fish);

            foreach (var animal in animals)
            {
                animal.Eat();
                animal.Sleep();
                animal.Poop();
            }

            Console.WriteLine("\nYour pig is " + pig.Color + " for some weird reason \nYour cat is " + cat.Color +
                "\nYour fish is " + fish.Color + "\n");

            List<Accessories> accessories = new List<Accessories>();

            var leash = new Leash();
            leash.Color = "Red";

            var food = new Food();
            food.Color = "Blue";

            var toy = new Toy();
            toy.Color = "Green";


            animals.Add(pig);
            animals.Add(cat);
            animals.Add(fish);

            foreach (var animal in animals)
            {
                animal.Eat();
                animal.Sleep();
                animal.Poop();
            }
            Console.WriteLine("\nYour leash color is " + leash.Color + " and the size is " + leash.Size + "\nYour food is " + food.Color + 
                " for some weird reason and you have " + food.Size + " of food \nYour toy is " + toy.Color + " and the size is " + toy.Size);
        }
    }
}