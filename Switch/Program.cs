using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Tom";

            switch (name)
            {
                case "Bob":
                    Console.WriteLine("Ваше имя - Bob");
                    break;
                case "Tom":
                    Console.WriteLine("Ваше имя - Tom");
                    break;
                case "Sam":
                    Console.WriteLine("Ваше имя - Sam");
                    break;
            }

            int number = 1;
            switch (number)
            {
                case 1:
                    Console.WriteLine("case 1");
                    goto case 5; // переход к case 5
                case 3:
                    Console.WriteLine("case 3");
                    break;
                case 5:
                    Console.WriteLine("case 5");
                    break;
                default:
                    Console.WriteLine("default");
                    break;
            }

            int DoOperation(int op, int a, int b)
            {
                switch (op)
                {
                    case 1: return a + b;
                    case 2: return a - b;
                    case 3: return a * b;
                    default: return 0;
                }
            }

            int DoOperation1(int op, int a, int b)
            {
                switch (op)
                {
                    case 1: return a + b;
                    case 2: return a - b;
                    case 3: return a * b;
                    default: return 0;
                }
            }

            int result1 = DoOperation1(1, 10, 5); // 15
            Console.WriteLine(result1);         // 15

            int result2 = DoOperation1(3, 10, 5); // 50
            Console.WriteLine(result2);         // 50

            int DoOperation2(int op, int a, int b)
            {
                int result = op switch
                {
                    1 => a + b,
                    2 => a - b,
                    3 => a * b,
                    _ => 0
                };
                return result;
            }
        }
    }
}
