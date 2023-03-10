using System;

namespace Example_001_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер дня: ");
            int dayIndex = int.Parse(Console.ReadLine());

            if(dayIndex == 1) Console.WriteLine("понедельник");
           
        }

    }

}