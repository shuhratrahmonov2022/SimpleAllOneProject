using System;

namespace Example_002_ImplicitTypeConversion
{
    class Program
    {
        static void Main(string[] args) 
        {
            byte byteValue = 1;
            short shortValue = byteValue;
            int intValue = shortValue;
            long longValue = intValue;
            double doubleValue = longValue;

            Console.WriteLine(doubleValue);
            char c = 'a';
            int d = c;

        }
    }
}