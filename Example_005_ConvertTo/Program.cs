using System;

namespace Example_005_ConvertTo
{
    class Program
    {
        static void Main(string[] args) 
        {
            string inputString = "2029";

            int intValue = Convert.ToInt32(inputString);
            Console.WriteLine(intValue);

            double dubleValue = Convert.ToDouble(inputString);
            Console.WriteLine(dubleValue);

            ulong ulongValue = Convert.ToUInt64(inputString);
            Console.WriteLine(ulongValue);

            #region Типы данных и их синонимы

            //Тип данных Тип .NET
            //sbyte  System.SByte
            //short  System.Int16
            //int    System.Int32
            //long   System.Int64
            //byte   System.Sbyte
            //ushort System.UInt16
            //uint   System.Uint32
            //ulong  System.UInt64
            //float  System.Single
            //doubl  System.Double
            //bool   System.Boolean


            #endregion  
        }
    }
}
