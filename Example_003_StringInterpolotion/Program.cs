﻿using System;

namespace Example_003_StringInterpolation
{
    class Program
    {
        static void Main(string[] args) 
        {
            string firstName = "Александр";
            string lastName = "Пушкин";
            string specialization = "Писатель";

            string pattern = "Имя: {0} Фамилия: {1} Специализация: {2}";

            Console.WriteLine(pattern,
                firstName, 
                lastName,
                specialization);

            Console.WriteLine($"Имя: {firstName} Фамилия: {lastName} Специализация: {specialization}");


            #region Калькулатор

            Console.ReadKey(); Console.Clear();

            int a = 100;
            int b = 11;
            int c = 111;
            Console.WriteLine($"{a} + {b} = {c}");

            #endregion


            #region База данных V 1.0

            Console.ReadKey(); Console.Clear();

            string name1 = "Агата", lastName1 = "Лебедева";
            string name2 = "Аделаида", lastName2 = "Виноградов";
            string name3 = "Алма", lastName3 = "Попова";
            string name4 = "Катя", lastName4 = "Калинина";
            string name5 = "Рената", lastName5 = "Иванова";

            Console.WriteLine($"{name1} {lastName1}");
            Console.WriteLine($"{name2} {lastName2}");
            Console.WriteLine($"{name3} {lastName3}");
            Console.WriteLine($"{name4} {lastName4}");
            Console.WriteLine($"{name5} {lastName5}");


            #endregion

            #region База данных V 2.0

            Console.ReadKey(); Console.Clear();

            Console.WriteLine($"{name1,10} {lastName1,11}");
            Console.WriteLine($"{name2,52} {lastName2,11}");
            Console.WriteLine($"{name3,10} {lastName3,11}");
            Console.WriteLine($"{name4,10} {lastName4,11}");
            Console.WriteLine($"{name5,10} {lastName5,11}");

            #endregion



        }
    }
}