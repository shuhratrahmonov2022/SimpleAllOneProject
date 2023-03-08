using System;

namespace Example_004
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int temporature = rand.Next(30);
            Console.WriteLine($"Текушая темпера = {temporature}'c");
            if (temporature < 10)
            {
                Console.WriteLine("На улица прохладна, рекомендую взять куртку потеплее");

            }
            else
            {
                Console.WriteLine("На улица тепло, теплая куртка не понадобится");
            }
        }
    }
}