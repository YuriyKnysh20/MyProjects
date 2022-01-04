using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers;
            int[] nums = new int[4];
            int[] nums2 = new int[4] { 1, 2, 3, 5 };
            string[] people = { "Tom", "Sam", "Bob" };

            int[] numbers1 = { 1, 2, 3, 5 };

            // получение элемента массива
            Console.WriteLine(numbers1[3]);  // 5

            // получение элемента массива в переменную
            var n = numbers1[1];     // 2
            Console.WriteLine(n);  // 2

            int[] numbers2 = { 1, 2, 3, 5 };

            // изменим второй элемент массива
            numbers2[1] = 505;

            Console.WriteLine(numbers2[1]);  // 505

            int[] numbers3 = { 1, 2, 3, 5 };

            Console.WriteLine(numbers3.Length);  // 4

            int[] numbers4 = { 1, 2, 3, 5 };

            Console.WriteLine(numbers4[numbers4.Length - 1]);  // 5 - последний элемент с конца
            Console.WriteLine(numbers4[numbers4.Length - 2]);  // 3 - предпоследний элемент с конца
            Console.WriteLine(numbers4[numbers4.Length - 3]);  // 2 - третий элемент с конца

            int[] numbers5 = { 1, 2, 3, 5 };

            Console.WriteLine(numbers5[^1]);  // 5 - последний элемент с конца
            Console.WriteLine(numbers5[^2]);  // 3 - предпоследний элемент с конца
            Console.WriteLine(numbers5[^3]);  // 2 - третий элемент с конца

            //Перебор массива

            int[] numbers6 = { 1, 2, 3, 4, 5 };
            foreach (int i in numbers6)
            {
                Console.WriteLine(i);
            }

            int[] numbers7 = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < numbers7.Length; i++)
            {
                numbers7[i] = numbers7[i] * 2;
                Console.WriteLine(numbers7[i]);
            }

            //Многомерные массивы
            int[] nums1 = new int[] { 0, 1, 2, 3, 4, 5 };

            int[,] nums3 = { { 0, 1, 2 }, { 3, 4, 5 } };

            int[,,] nums4 = new int[2, 3, 4];

            int[,] numbers8 = { { 1, 2, 3 }, { 4, 5, 6 } };

            int rows = numbers8.GetUpperBound(0) + 1;    // количество строк
            int columns = numbers8.Length / rows;        // количество столбцов
                                                        // или так
                                                        // int columns = numbers.GetUpperBound(1) + 1;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{numbers8[i, j]} \t");
                }
                Console.WriteLine();
            }

            int[][] nums5 = new int[3][];
            nums5[0] = new int[2] { 1, 2 };          // выделяем память для первого подмассива
            nums5[1] = new int[3] { 1, 2, 3 };       // выделяем память для второго подмассива
            nums5[2] = new int[5] { 1, 2, 3, 4, 5 }; // выделяем память для третьего подмассива


            int[][] numbers9 = new int[3][];
            numbers9[0] = new int[] { 1, 2 };
            numbers9[1] = new int[] { 1, 2, 3 };
            numbers9[2] = new int[] { 1, 2, 3, 4, 5 };
            foreach (int[] row in numbers9)
            {
                foreach (int number9 in row)
                {
                    Console.Write($"{number9} \t");
                }
                Console.WriteLine();
            }

            // перебор с помощью цикла for
            for (int i = 0; i < numbers9.Length; i++)
            {
                for (int j = 0; j < numbers9[i].Length; j++)
                {
                    Console.Write($"{numbers9[i][j]} \t");
                }
                Console.WriteLine();
            }
            //Количество положительных чисел

            int[] numbers10 = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
            int result = 0;
            foreach (int number10 in numbers10)
            {
                if (number10 > 0)
                {
                    result++;
                }
            }
            Console.WriteLine($"Число элементов больше нуля: {result}");

            //Инверсия массива
            int[] numbers11 = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };

            int n1 = numbers11.Length; // длина массива
            int k = n / 2;          // середина массива
            int temp;               // вспомогательный элемент для обмена значениями
            for (int i = 0; i < k; i++)
            {
                temp = numbers11[i];
                numbers11[i] = numbers11[n - i - 1];
                numbers11[n1 - i - 1] = temp;
            }
            foreach (int i in numbers11)
            {
                Console.Write($"{i} \t");
            }

            int[] nums12 = { 54, 7, -41, 2, 4, 2, 89, 33, -5, 12 };

            // сортировка
            int temp1;
            for (int i = 0; i < nums12.Length - 1; i++)
            {
                for (int j = i + 1; j < nums12.Length; j++)
                {
                    if (nums12[i] > nums12[j])
                    {
                        temp1 = nums12[i];
                        nums12[i] = nums12[j];
                        nums12[j] = temp1;
                    }
                }
            }

            // вывод
            Console.WriteLine("Вывод отсортированного массива");
            for (int i = 0; i < nums12.Length; i++)
            {
                Console.WriteLine(nums12[i]);
            }
        }
    }
}
