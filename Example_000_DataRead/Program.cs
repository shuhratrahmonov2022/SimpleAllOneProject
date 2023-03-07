using System;

namespace Example_000_DataRead
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Билл Гейтс";
            byte age = 63;
            ushort costs = 118;

            #region ___
            Console.Write("Имя: ");
            name = Console.ReadLine();

            Console.Write("Введите возраст: ");
            age = byte.Parse(Console.ReadLine());

            Console.Write("Введите сумму ежесячных трат: ");
            costs = Convert.ToUInt16(Console.ReadLine());

            #endregion

            Console.WriteLine("Имя: " + name + " Возраст: " + age + " Расходы: $" + costs);
            Console.WriteLine("Имя: {0} Возраст: {1} Расходы: ${2}",name,age,costs);
            Console.WriteLine($"Имя: {name} Возраст: {age} Расходы: ${costs}");

            Console.ReadKey();



        }
    }

}