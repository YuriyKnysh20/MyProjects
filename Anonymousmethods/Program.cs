using System;

namespace Anonymousmethods
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageHandler handler = delegate (string mes)
            {
                Console.WriteLine(mes);
            };
            handler("hello world!");

            ShowMessage("hello!", delegate (string mes)
            {
                Console.WriteLine(mes);
            });

            static void ShowMessage(string message, MessageHandler1 handler)
            {
                handler(message);
            }
            int z = 8;
            Operation operation = delegate (int x, int y)
            {
                return x + y + z;
            };
            int result = operation(4, 5);
            Console.WriteLine(result);       // 17

        }

    }
    delegate void MessageHandler(string message);
    delegate void MessageHandler1(string message);
    delegate int Operation(int x, int y);
}
