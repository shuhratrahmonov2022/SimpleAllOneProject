﻿using System;

namespace Example_003_
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int value = 5;

            if (value > 0 && value < 5)
            {
                Console.WriteLine("0 <= value < 57");
            }
            else if(value >= 5 && value < 10) 
            {
                Console.WriteLine("5 <= value < 10");
            }

            #region switch вариант 1

            //switch (value)
            //{
            //    case 0:
            //    case 1:
            //    case 2:
            //    case 3:
            //    case 4:Console.WriteLine("0 <= value < 5");break;
            //    case 5:
            //    case 6:
            //    case 7:
            //    case 8:
            //    case 9:Console.WriteLine("5 <= value < 10");break;   
            //}

            #endregion

            #region switch ешё один вариант

            switch (value)
            {
                case 0: Console.WriteLine("0 <= value < 5"); break;
                case 1: Console.WriteLine("0 <= value < 5"); break;
                case 2: Console.WriteLine("0 <= value < 5"); break;
                case 3: Console.WriteLine("0 <= value < 5"); break;
                case 4: Console.WriteLine("0 <= value < 5"); break;
                case 5: Console.WriteLine("0 <= value < 10"); break;
                case 6: Console.WriteLine("0 <= value < 10"); break;
                case 7: Console.WriteLine("0 <= value < 10"); break;
                case 8: Console.WriteLine("0 <= value < 10"); break;
                case 9: Console.WriteLine("0 <= value < 10"); break;
            }

            #endregion










        }
    }
}