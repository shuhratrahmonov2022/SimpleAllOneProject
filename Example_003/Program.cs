using System;

namespace Example_003
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int a = rand.Next(-21, 23);
            int b = rand.Next(-21, 23);

            bool f = a > b;
            int outputInt = f ? a : b;
            Console.WriteLine(outputInt);

            string outputString = f ? "да" : "нет";

            var result = f ? "да" : "нет";

            Console.WriteLine(outputString);
            Console.WriteLine(result);
        }
    }
}