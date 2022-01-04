using System;

namespace Bitwiseoperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 2; //010
            int y1 = 5;//101
            Console.WriteLine(x1 & y1); // выведет 0

            int x2 = 4; //100
            int y2 = 5; //101
            Console.WriteLine(x2 & y2); // выведет 4
  

            int x3 = 2; //010
            int y3 = 5;//101
            Console.WriteLine(x1 | y1); // выведет 7 - 111
            int x4 = 4; //100
            int y4 = 5;//101
            Console.WriteLine(x2 | y2); // выведет 5 - 101
           

            int x = 45; // Значение, которое надо зашифровать - в двоичной форме 101101
            int key = 102; //Пусть это будет ключ - в двоичной форме 1100110

            int encrypt = x ^ key; //Результатом будет число 1001011 или 75
            Console.WriteLine($"Зашифрованное число: {encrypt}");

            int decrypt = encrypt ^ key; // Результатом будет исходное число 45
            Console.WriteLine($"Расшифрованное число: {decrypt}");
          


            int x5 = 12;                 // 00001100
            Console.WriteLine(~x5);      // 11110011   или -13
          
             int x6 = 12;
            int y = ~x6;
            y += 1;
            Console.WriteLine(y);   // -12

            //Операции сдвига

            int a = 16; // в двоичной форме 10000
            int b = 2; // в двоичной форме
            int c = a << b; // Сдвиг числа 10000 влево на 2 разряда, равно 1000000 или 64 в десятичной системе

            Console.WriteLine($"Зашифрованное число: {c}");    // 64

            int d = a >> b; // Сдвиг числа 10000 вправо на 2 разряда, равно 100 или 4 в десятичной системе
            Console.WriteLine($"Зашифрованное число: {d}");     // 4

            int a1 = 22; // в двоичной форме 10110
            int b1 = 2; // в двоичной форме
            int c1 = a1 << b1; // Сдвиг числа 10110 влево на 2 разряда, равно 1011000 или 88 в десятичной системе

            Console.WriteLine($"Зашифрованное число: {c1}");    // 88

            int d1 = a1 >> b1; // Сдвиг числа 10110 вправо на 2 разряда, равно 101 или 5 в десятичной системе
            Console.WriteLine($"Зашифрованное число: {d1}");     // 5
        }
    }
}
