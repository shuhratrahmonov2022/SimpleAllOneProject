using System;

namespace Example_002_
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите уровень сложности. - Простой, 2 - Средний, 3 - Сложный");

            int level;

            level = Convert.ToInt32(Console.ReadLine());

            #region if-else
            if (level == 1)
            {
                Console.WriteLine("NPC сгенерирован");
                Console.WriteLine("NPC сгенерирован");
            }
            else if (level == 2)
            {
                Console.WriteLine("NPC сгенерирован");
                Console.WriteLine("NPC сгенерирован");
                Console.WriteLine("NPC сгенерирован");
            }
            else if (level == 3)
            {
                Console.WriteLine("NPC сгенерирован");
                Console.WriteLine("NPC сгенерирован");
                Console.WriteLine("NPC сгенерирован");
                Console.WriteLine("NPC сгенерирован");
            }
            else
            {
                Console.WriteLine("NPC сгенерирован");
            }

            #endregion


            #region switch

            switch (level)
            {
                case 1:
                    Console.WriteLine("NPC сгенерирован");
                    Console.WriteLine("NPC сгенерирован");
                    break;

                case 2:
                    Console.WriteLine("NPC сгенерирован");
                    Console.WriteLine("NPC сгенерирован");
                    Console.WriteLine("NPC сгенерирован");
                    Console.WriteLine("NPC сгенерирован");
                    break;

                case 3:
                    Console.WriteLine("NPC сгенерирован");
                    Console.WriteLine("NPC сгенерирован");
                    Console.WriteLine("NPC сгенерирован");
                    Console.WriteLine("NPC сгенерирован");
                    Console.WriteLine("NPC сгенерирован");
                    break;

                default:
                    Console.WriteLine("NPC сгенерирован");
                    break;
            }

            #endregion

        }
    }
}