using System;

namespace LocaleFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            void Compare(int[] numbers1, int[] numbers2)
            {
                int numbers1Sum = Sum(numbers1);
                int numbers2Sum = Sum(numbers2);

                if (numbers1Sum > numbers2Sum)
                    Console.WriteLine("сумма чисел из массива numbers1 больше");
                else
                    Console.WriteLine("сумма чисел из массива numbers2 больше");

                int Sum(int[] numbers)
                {
                    int result = 0;
                    foreach (int number in numbers)
                        result += number;
                    return result;
                }
            }

            int[] numbers1 = { 1, 2, 3 };
            int[] numbers2 = { 3, 4, 5, 6, 7 };

            Compare(numbers1, numbers2);

            int Sum(int[] numbers)
            {
                int result = 0;
                int limit = 0;
                foreach (int number in numbers)
                {
                    if (IsPassed(number, limit)) result += number;
                }
                return result;

                static bool IsPassed(int number, int lim)
                {
                    //return number > limit; // Ошибка: метод IsPassed не имеет доступа к переменной limit
                    return number > lim;
                }
            }
        }
    }
}
