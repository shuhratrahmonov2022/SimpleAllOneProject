using System;

namespace Example_001_ArithmeticOperations
{
    class Program
    {
        static void Main(string[] args) 
        {
            #region Сумма + 

            int valueA = 2_140_000_003; int valueB = 2_140_00_003;
            double valueC = (double)valueA + (double)valueB;
           // int valueC = valueA + valueB;

            Console.WriteLine(valueC);

            double valueD = 20.22; double valueE = 20.25;
            double valueI = valueD + valueE;

            //sbyte valueF = 123; short value valueG = 22;
            //var valueH = valueF + valueG;

            long valueK = 32; byte valueL = 11;
            var valueM = valueK + valueL;

            #endregion

            #region Разность -

            //int valueA = 3; int valueB = 2019;
            //int valueC = valueA - valueB;

            //double valueD = 20.23; double valueE = 20.25;
            //double valueI = valueD - valueE;

            //sbyte valueF = 123; short valueG = 22;
            //var valueH = valueF - valueG;

            //long valueK = 32; byte value = 11;
            //var valueM = valueK - valueL;

            #endregion

            #region Произведение *

            //int valueA = 3; int valueB = 2019;
            //int valueC = valueA * valueB;

            //double valueD = 20.22; double valueE = 20.25;
            //double valueI = valueD * valueE;

            //sbyte valueF = 123; short valueG = 22;
            //var valueH = valueF * valueG;

            //long valueK = 32; byte valueL = 11;
            //var valueM = valueK * valueL;

            #endregion


            #region Частное /




            // int valuA = 10; int valueB = 2;
            // int valueC = valueA / valueB;
            // Console.WriteLine(valueC);

            //int valueA = 5; int valueB = 2;
            //int valueC = valueA / valueB;
            //Console.WriteLine(valueC);

            #endregion


            #region Остаток от деления % 


            Console.WriteLine("Деление в целых числах. Остаток");
            Console.WriteLine($"5 % 2 = {5 % 2}");
            Console.WriteLine($"5 % 2 = {5 % 2}");
            Console.WriteLine($"59 % 8 = {59 % 8}");
            Console.WriteLine($"21 % 4 = {21 % 4}");

            #endregion




        }
    }
}