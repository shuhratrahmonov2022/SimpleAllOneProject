using System;

namespace Example_004_LogicalOperations
{
    class Program
    {
        static void Main(string[] args) 
        {
            bool variable1 = true;
            bool variable2 = false;

            #region  Инверсия / Отрицание / Логическое "Не" / !

            Console.WriteLine("Инверсия: ");

            Console.WriteLine($"variable1 = {variable1}  !variable1 = {!variable1}");
            Console.WriteLine($"variable1 = {variable2}  !variable1 = {!variable2}");

            #endregion


            #region Конъюнкция / Логическое умножение / Логическое "И" / &&

            Console.WriteLine("\nКонъюнкция: ");


            variable1 = true;
            variable2 = false;

            bool result = variable1 && variable2;

            Console.WriteLine($"{true} && {true} = {true && true}");
            Console.WriteLine($"{true} && {false} = {true && false}");
            Console.WriteLine($"{false} && {true} = {false && true}");
            Console.WriteLine($"{false} && {false} = {false && false}");
            #endregion


            #region Дизъюнкция / Логическое сложение / Логическое "ИЛИ" / ||

            Console.WriteLine("\n Дизъюнкция: ");



            variable1 = true;
            variable2 = false;


            bool resut = variable1 || variable2;

            Console.WriteLine($"{true} || {true} = {true || true}");
            Console.WriteLine($"{true} || {false} = {true || false}");
            Console.WriteLine($"{false} || {true} = {false || true}");
            Console.WriteLine($"{false} || {false} = {false || false}");

            #endregion

            #region Разделительная дизъюнкция / Строгая дизъюнкция / Исключащее "ИЛИ" / ^

            Console.WriteLine("\nРазделительная дизъюнкция: ");

            variable1 = true;
            variable2 = false;
            
            result = variable1 ^ variable2;

            Console.WriteLine($"{true} ^ {true} = {true ^ true}");
            Console.WriteLine($"{true} ^ {false} = {true ^ false}");
            Console.WriteLine($"{false} ^ {true} = {false ^ true}");
            Console.WriteLine($"{false} ^ {false} = {false ^ false}");

            #endregion

            #region Другие операция 

            bool flag1 = 4 > 5; Console.WriteLine(flag1);
            bool flag2 = 1 < 3; Console.WriteLine(flag2);

            char c = 'f';

            bool flag3 = c == 'f'; Console.WriteLine(flag3);
            bool flag4 = 28 == 28; Console.WriteLine(flag4);
            bool flag5 = 28 >= 24; Console.WriteLine(flag5);
            bool flag6 = 9 <= 9; Console.WriteLine(flag6);
            bool flag7 = 28 != 90; Console.WriteLine(flag7);

            string s = "c#";
            bool flag8 = 28 != 90 && s == "c#"; Console.WriteLine(flag8);

            #endregion



        }
    }
}