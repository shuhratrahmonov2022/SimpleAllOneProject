using System;

namespace Example_002_If
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int x = rand.Next(3);
            Console.WriteLine($"Полуено значение x = {x}");

            if (x < 2)
                Console.WriteLine("x равен 0 или 1");


            if (x < 2)
            {
                Console.WriteLine("x равен 0 или 1");

            }
          
        }

    }
}