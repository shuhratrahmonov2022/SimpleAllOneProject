using System;

namespace Example_001_FormatedOutput
{
    class Program
    {
        static void Main(string[] args) 
        {
            string firstName = "Александр";
            string lastName = "Пушкин";
            string specialization = "Писатель";

            byte age = 37;
            ulong yearOfBirth = 1799;

            Console.WriteLine(firstName + lastName + specialization + age + yearOfBirth);
            Console.ReadKey();

            Console.WriteLine(firstName+ " " + lastName + " " + specialization + " " + yearOfBirth);
            Console.ReadKey();

            Console.WriteLine("Имя: " + firstName + " Фамилия: " + lastName + " Спициализация: " + specialization + " Возраст: " + age + " Год рождения: " + yearOfBirth);
            Console.ReadKey();

            Console.WriteLine("Имя: {0} Фамилия: {1} Спициализация: {2} Возраст: {3} Год рождения: {4}", 
                firstName, 
                lastName, 
                specialization, 
                age, 
                yearOfBirth);

            Console.ReadKey();

            string pattern = "Имя: {0} Фамилия: {1} Специализация: {2} Возраст: {3} Год рождения: {4}";
            Console.WriteLine(pattern,
                firstName,
                lastName,
                specialization, 
                age,
                yearOfBirth);

            #region переиспользование pattern

            string fName = "Ада";
            string lName = "Лавлейс";
            string profession = "Программист";

            byte years = 37;
            ulong birth = 1815;

            Console.WriteLine(pattern,
                fName,
                lName,
                profession,
                years,
                birth);


            #endregion 



        }
    }
}