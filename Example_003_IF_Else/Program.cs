using System;

namespace Example_003_IF_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int x = rand.Next(3);
            Console.WriteLine($"Получено значение x = {x}");

            //if(x == 1) Console.WriteLine("x == 1");
            //else Console.WriteLine("x != 1");

            //if (x == 1)
            //{
            //    Console.WriteLine("X == 1");
            //    Console.WriteLine();
            //    Console.WriteLine();
            //    Console.WriteLine();

            //}
            //else
            //{
            //    Console.WriteLine("x != 1");
            //}

            #region if-else-if

            if (x < 1) Console.WriteLine("x < 1");
            else if (x > 1) Console.WriteLine("x > 1");
            else Console.WriteLine("x = 1");

            #endregion

            #region Пример записи 1
            Console.ReadKey();

            if (x < 1)
            {
                Console.WriteLine("x < 1");
            }
            else if (x > 1)
            {
                Console.WriteLine("x > 1");
            }
            else
            {
                Console.WriteLine("x = 1");
            }

            #endregion

            #region Пример записи 2
            Console.ReadKey();
            if (true)
            {

            }
            else
            {
                if (true)
                {

                }
                else
                {
                    if (true)
                    {

                    }
                    else
                    {
                    }
                }
            }
            if (x < 1)
            {
                Console.WriteLine("x < 1");
            }
            else
            {
                if (x > 1)
                {
                    Console.WriteLine("x > 1");
                }
                else
                {
                    Console.WriteLine("x = 1");
                }
            }
            #endregion

        }
    }
}

