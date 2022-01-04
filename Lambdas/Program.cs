using System;

namespace Lambdas
{
    class Program
    {
        static void Main(string[] args)
        {
            Message hello = () =>
            {
                Console.Write("Hello ");
                Console.WriteLine("World");
            };
            hello();       // Hello World

            Operation sum = (x, y) => Console.WriteLine($"{x} + {y} = {x + y}");
            sum(1, 2);       // 1 + 2 = 3
            sum(22, 14);    // 22 + 14 = 36

            Operation1 sum1 = (int x, int y) => x + y;
            int sumResult = sum1(4, 5);                  // 9
            Console.WriteLine(sumResult);               // 9

            Operation1 multiply = (x, y) => x * y;
            int multiplyResult = multiply(4, 5);        // 20
            Console.WriteLine(multiplyResult);          // 20
        }
    }
    delegate void Message();
    delegate void Operation(int x, int y);
    delegate int Operation1(int x, int y);
}
