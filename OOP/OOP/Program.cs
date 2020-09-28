using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet dav = new Pet();
            dav._name = "Dav";
            dav._species = "Gris";
            dav._color = "Blå";

            Person andreas = new Person("Andreas", 17, dav);

            andreas.Name = "";

            andreas.Eat();
            andreas.Sleep();

            andreas.ActivatePet();

        }
    }
}
