using System;

namespace Example_005_MathLogicalOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 30, x2 = 150;
            int y1 = 20, y2 = 90;

            int pA = 200, pB = 90;
            bool check = ((pA >= x1) && (pA <= x2)) && ((pB >= y1) && (pB <= y2));
            Console.WriteLine(check);

        }
    }
}