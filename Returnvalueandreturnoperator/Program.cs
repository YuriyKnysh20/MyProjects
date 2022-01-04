using System;

namespace Returnvalueandreturnoperator
{
    class Program
    {
        static void Main(string[] args)
        {
            string GetMessage()
            {
                return "Hello";
            }

            string message = GetMessage();  // получаем результат метода в переменную message
            Console.WriteLine(message);     // Hello

            void PrintMessage(string message)
            {
                Console.WriteLine(message);
            }
            PrintMessage(GetMessage());

            int Sum(int x, int y)
            {
                return x + y;
            }

            int result = Sum(10, 15);   // 25
            Console.WriteLine(result);   // 25

            Console.WriteLine(Sum(5, 6));   // 11

            void PrintPerson(string name, int age)
            {
                if (age > 120 || age < 1)
                {
                    Console.WriteLine("Недопустимый возраст");
                    return;
                }
                Console.WriteLine($"Имя: {name}  Возраст: {age}");
            }

            PrintPerson("Tom", 37);         // Имя: Tom  Возраст: 37
            PrintPerson("Dunkan", 1234);    // Недопустимый возраст
        }
    }
}
