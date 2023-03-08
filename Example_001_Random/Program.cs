using System;

namespace Example_001_Random
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomize = new Random();

            Console.WriteLine($"int.MaxValue = {int.MaxValue}");
            Console.WriteLine($"int.MinValue = {int.MinValue}\n");

            #region Замечание

            #endregion

            int randomIntResult = randomize.Next();

            Console.WriteLine($"Пример 1. randomIntResult = {randomIntResult}");

            randomIntResult = randomize.Next(100);

            Console.WriteLine($"Пример 2. randomIntResult = {randomIntResult}");
            randomIntResult = randomize.Next(10, 100) * randomize.Next(100);

            Console.WriteLine($"Пример 3. randomIntResult = {randomIntResult}");

            Console.WriteLine($"Пример 4. randomDoubleResult = {randomIntResult}");


        }
    }
}