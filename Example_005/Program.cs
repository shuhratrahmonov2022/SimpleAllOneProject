using System;

namespace Example_005
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int firstNumber = rand.Next(-10, 11);
            int secondNumber = rand.Next(-10, 11);

            #region Пункт: 1 Вариант 1

            Console.WriteLine("Пункт 1 вариант 3");

            if (firstNumber > secondNumber)
            {
                Console.WriteLine($"Максимальное число = {firstNumber}");
            }
            else
            {
                Console.WriteLine($"Максимальное число = {secondNumber}");
            }

            if (firstNumber < secondNumber)
            {
                Console.WriteLine($"Минимальное число = {firstNumber}");
            }
            else
            {
                Console.WriteLine($"Минимальное число = {secondNumber}");
            }

            #endregion

            #region Пункт 1 вариант 2

            Console.WriteLine("\nПункт 1 вариант 3");

            if (firstNumber > secondNumber)
            {
                Console.WriteLine($"Максимальное число = {firstNumber}");
                Console.WriteLine($"Минимальное число = {secondNumber}");
            }
            else
            {
                Console.WriteLine($"Максимальное число = {secondNumber}");
                Console.WriteLine($"Минимальное число = {firstNumber}");
            }

            #endregion

            #region Пункт 1 вариант 3

            Console.WriteLine("\nПункт 1 вариант 3");

            bool flag = firstNumber > secondNumber;

            if (flag)
            {
                Console.WriteLine($"Максимальное число = {firstNumber}");
                Console.WriteLine($"Минимальное число = {secondNumber}");
            }
            else
            {
                Console.WriteLine($"Максимальное число = {secondNumber}");
                Console.WriteLine($"Минимальное число = {firstNumber}");

            }


            #endregion

            #region Пункт 1 вариант 4

            Console.WriteLine("\nПункт 1 вариант 4");

            int maxValue, minValue;
            
            if (firstNumber > secondNumber)
            {
                maxValue = firstNumber;
                minValue = secondNumber;
            }
            else
            {
                maxValue = secondNumber;
                minValue = firstNumber;

            }

            Console.WriteLine($"Максимальное число = {maxValue}");
            Console.WriteLine($"Минималье число = {minValue}");


            #endregion

            #region Пункт 2

            Console.WriteLine("\nПункт 2");

            if (firstNumber > secondNumber)
            {
                maxValue = firstNumber;
                minValue = secondNumber;
            }
            else if (firstNumber < secondNumber)
            {
                maxValue = secondNumber;
                minValue = firstNumber;
            }
            else
            {
                Console.WriteLine("Числа равны");
            }

            Console.WriteLine($"Максимальное число = {maxValue}");
            Console.WriteLine($"Минимальное число = {minValue}");

            #endregion

            #region Пункт 3

            Console.WriteLine("Введите первое число: ");
            //int firstNumber = int.Parse( Console.ReadLine());

            Console.WriteLine("Ввеите второе число: ");
            //int secondNumber = int.Parse(Console.ReadLine());


            #endregion

        }

    }
}