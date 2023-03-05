using System;

namespace Homework_Theme_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            double height;
            int history, math, russian;

            Console.Write("Введите Имя: ");
            name = Console.ReadLine();

            Console.Write("Введите Возраст: ");
            age = int.Parse(Console.ReadLine());

            Console.Write("Введите Рост: ");
            height = double.Parse(Console.ReadLine());

            Console.Write("Введите баллы История: ");
            history = int.Parse(Console.ReadLine());

            Console.Write("Введите баллы Математика: ");
            math = int.Parse(Console.ReadLine());

            Console.Write("Введите баллы Русский язык: ");
            russian = int.Parse(Console.ReadLine());

            double average = (history + math + russian) / 3.0;

            Console.WriteLine();
            Console.WriteLine("Ваше имя: " + name);
            Console.WriteLine("Ваше Возраст: " + age);
            Console.WriteLine("Ваше Рост: " + height);
            Console.WriteLine("Ваше средний балл: " + average);

            Console.WriteLine();
            Console.WriteLine("{0,-20} {1}", "Ваше имя: ", name);
            Console.WriteLine("{0,-20} {1}", "Ваше Возраст: ", age);
            Console.WriteLine("{0,-20} {1}", "Ваше Рост: ", height);
            Console.WriteLine("{0,-20} {1}", "Ваше средний балл: ",average);

            Console.WriteLine();
            Console.WriteLine($"Ваше имя:{name} Ваше Возраст: {age} Ваше рост: {height}  Ваше средний балл: {average:F1}");

            int windowWidth = Console.WindowWidth;

            string data = $"Имя: {name}, Возраст: {age}, Рост: {height}, Средний балл: {average:F1}";

            int space = (windowWidth - data.Length) / 2;

            data = data.PadLeft(data.Length + space);

            Console.WriteLine("\n"+data);

        }
    }
}