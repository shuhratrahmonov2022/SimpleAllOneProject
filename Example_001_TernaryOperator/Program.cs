using System;

namespace Example_001
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            double x = rand.NextDouble();
            
            int result = (x < 0.5) ? 0 : 1;
            Console.WriteLine($"result = {result}");

            if (x < 0.5)
            {
                result = 0;
            }
            else
            {
                result = 1;
            }
            Console.WriteLine($"result = {result}");

            #region Замечание
 
            Console.ReadKey();

            Console.WriteLine(x < 0.5 ? 0 : 1);

            if (x < 0.5)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(1);
            }
            #endregion 
        }
    }
}