using System;

namespace Example_004_NumberAfterPoint
{
    class Program
    {
        static void Main(string[] args) 
        {
            double d = 123456.654321;
            Console.WriteLine(d);

            string dFormated = d.ToString("#.###");
            Console.WriteLine(dFormated);

            Console.WriteLine("{0:0.000}", d);

            Console.WriteLine(d.ToString("#.###"));

            dFormated = d.ToString("#.## ## ## ## ##");
            Console.WriteLine(dFormated);

            dFormated = d.ToString("### ###.## ## ## ## ##");
            Console.WriteLine(dFormated);

            Console.WriteLine("{0:000 000 000.000 00 000}", d);



            #region Замечание

            Console.WriteLine();
            var date = new DateTime(2025, 09, 28, 01, 30, 59);
            Console.WriteLine(date);


            Console.ReadKey();
            Console.WriteLine($"{date:HH:mm}");
            Console.WriteLine($"{date:yyyy-MM-dd}");
            Console.WriteLine($"{date:yy.MM.dd}");
            Console.WriteLine($"{date:dd.MM.yyy}");



            #endregion
        }
    }
}