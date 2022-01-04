using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            bool alive = true;
            bool isDead = false;
           
            byte bit1 = 1;
            byte bit2 = 102;
            
            sbyte bit3 = -101;
            sbyte bit4 = 102;
           
            short n1 = 1;
            short n2 = 102;
           
            ushort n3 = 1;
            ushort n4 = 102;
            
            int a = 10;
            int b = 0b101;  // бинарная форма b =5
            int c = 0xFF;   // шестнадцатеричная форма c = 255
            
            uint d = 10;
            uint e = 0b101;
            uint f = 0xFF;
            
            long g = -10;
            long h = 0b101;
            long u = 0xFF;
           
            ulong w = 10;
            ulong q = 0b101;
            ulong p = 0xFF;
            float l = 0.09f;

            double j = 90d;

            decimal m = 78.9M;

            char A = 'A';
            char B = '\x5A';
            char C = '\u0420';
            
            string hello = "Hello";
            string word = "world";
            


            object L = 22;
            object N = 3.14;
            object Y = "hello code";
            
            string name = "Tom";
            int age = 33;
            bool isEmployed = false;
            double weight = 78.65;

            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"Вес: {weight}");
            Console.WriteLine($"Работает: {isEmployed}");
            //Исопльзование суффиксов

            uint O = 10U;
            long P = 20L;
            ulong T = 30UL;

            int J = 4;
            System.Int32 R = 4;

            //Неявная типизация

            var hello1 = "Hell to World";
            var U = 20;
        }
    }
}
