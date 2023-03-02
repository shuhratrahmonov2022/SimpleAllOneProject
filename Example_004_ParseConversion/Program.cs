using System;

namespace Example_004_ParseConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = "2029";
            int intValue = int.Parse(inputString);
            Console.WriteLine(intValue);

            double doubleValue = double.Parse(inputString);
            Console.WriteLine(doubleValue);

            ulong ulongValue = ulong.Parse(inputString);
            Console.WriteLine(ulongValue);

            byte byteValue = byte.Parse(inputString);
            Console.WriteLine(byteValue);

        }
    }
}