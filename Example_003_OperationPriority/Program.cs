using System;

namespace Example_003_OperationsPriority
{
    class Program
    {
        static void Main(string[] args) 
        {

            //
            // Унарные операции
            // Префиксный инкремент
            // %, /, *
            // +, -
            // Постфиксный инкремент
            // () - скобки меняют приоритет операций
            //

            //Console.WriteLine(2*2+2);


            //int a = 10;
            //a = -a;
            //Console.WriteLine(a);

            int a = 0;

            Console.WriteLine(++a);
            Console.WriteLine(a);
        }
    }
}