using System;

namespace Example_006
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер дня: ");
            int dayIndex = int.Parse(Console.ReadLine());

            #region Вариант 1

            if (dayIndex == 1)
            {
                Console.WriteLine("Понедельник");
            }
            else 
            {
                if (dayIndex == 2)
                {
                    Console.WriteLine("Вторник");
                }
                else
                {
                    if (dayIndex == 3)
                    {
                        Console.WriteLine("Среда");
                    }
                    else
                    {
                        if (dayIndex == 4)
                        {
                            Console.WriteLine("Четверг");
                        }
                        else
                        {
                            if (dayIndex == 5)
                            {
                                Console.WriteLine("Пятница");
                            }
                            else
                            {
                                if (dayIndex == 6)
                                {
                                    Console.WriteLine("Суббота");
                                }
                                else
                                {
                                    if (dayIndex == 7)
                                    {
                                        Console.WriteLine("Воскресеные");
                                    }
                                    else
                                    {
                                        Console.WriteLine("На планете Земля в неделе семь дней");
                                    }
                                }
                            }
                        }
                    }
                }
            }
            #endregion

            #region Вариант 2

            if(dayIndex == 1) Console.WriteLine("Понедельник");
            else if(dayIndex == 2) Console.WriteLine("Вторник");
            else if(dayIndex == 3) Console.WriteLine("Среда");
            else if(dayIndex == 4) Console.WriteLine("Четверг");
            else if(dayIndex == 5) Console.WriteLine("Пятница");
            else if(dayIndex == 6) Console.WriteLine("Суббота");
            else if(dayIndex == 7) Console.WriteLine("Воскресенье");
            else Console.WriteLine("На планете Земля в неделе семь дней");

            #endregion
        }
    }
}
