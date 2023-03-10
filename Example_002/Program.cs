using System;
using System.Security.AccessControl;

namespace Example_002
{
    class Program
    {
        static void Main(string[] args)
        {


            #region Решение if-else
            Random rand = new Random();

            int firstNumber = rand.Next(-21, 23);
            int secondNumber = rand.Next(-21, 23);
            int thirdNumber = rand.Next(-21, 23);
           
            int maxvalue;

            if ((firstNumber > secondNumber) && (firstNumber > thirdNumber))
            {
                maxvalue = firstNumber;
            }
            else
            {
                if ((secondNumber > firstNumber) && (secondNumber > thirdNumber))
                {
                    maxvalue = secondNumber;
                }
                else
                {
                    maxvalue = thirdNumber;
                }
            }

            Console.WriteLine($"Максимальное значение = {maxvalue}");

            #endregion
        }
    }
}