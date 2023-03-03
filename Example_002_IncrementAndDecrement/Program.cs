using System;

namespace Example_002_IncrementAndDecrement
{
    class Program
    {
        static void Main(string[] args) 
        {
            #region +=
            Console.ReadKey(); Console.WriteLine("\n+=");

            //int a = 12;
            //int b = 13;
            //int c = a + b;
            //Console.WriteLine(c);

            //a = a + b;
            //a += b;
            //Console.WriteLine(a);

            #endregion


            #region -=
            //Console.ReadKey(); Console.WriteLine("\n-=");

            //int a = 12;
            //int b = 13;
            //int c = a - b;
            //Console.WriteLine(c);

            ////a = a - b;
            //a -= b;

            //Console.WriteLine(a);
            #endregion

            #region  *=
            //Console.ReadKey(); Console.WriteLine("\n*=");

            //int a = 4;
            //int b = 5;
            //int c = a * b;

            //Console.WriteLine(c);

            ////a = a * b;
            //a *= b;
            //Console.WriteLine(a);

            #endregion


            #region /=

            Console.ReadKey(); Console.WriteLine("\n/=");

            int a = 33;
            int b = 11;
            int c = a / b;

            Console.WriteLine(c);

            //a = a / b;
            a /= b;

            Console.WriteLine(a);

            a = 30;
            b = 11;
            c = a / b;
            Console.WriteLine(c);

            a /= b;
            Console.WriteLine(a);

            double d = 10;
            double e = 4;
            d /= e;
            Console.WriteLine(d);

            #endregion

            #region %=


            Console.ReadKey(); Console.WriteLine("\n%=");

            a = 14;
            b = 5;
            c = a % b;

            Console.WriteLine(c);

            //a = a % b;
            a = a % b;

            Console.WriteLine(a);

            #endregion

            #region ++

            Console.ReadKey(); Console.WriteLine("\n++");

            a = 10;

            a += 20;
            Console.WriteLine(a);

            a += 1;
            Console.WriteLine(a);

            a++;
            Console.WriteLine(a);

            ++a;
            Console.WriteLine(a);

            #endregion


            #region --

            Console.ReadKey(); Console.WriteLine("\n--");

            a = 50;

            a -= 20;

            Console.WriteLine(a);

            a -= 1;
            Console.WriteLine(a);

            a--;
            Console.WriteLine(a);

            --a;
            Console.WriteLine(a);


            #endregion





        }
    }
}