using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Message mes;            // 2. Создаем переменную делегата
            mes = Hello;            // 3. Присваиваем этой переменной адрес метода
            mes();                  // 4. Вызываем метод

            void Hello() => Console.WriteLine("Hello METANIT.COM");

            Message message1 = Welcome.Print;
            Message message2 = new Hello().Display;

            message1(); // Welcome
            message2(); // Привет

            Operation operation = Add;      // делегат указывает на метод Add
            int result = operation(4, 5);   // фактически Add(4, 5)
            Console.WriteLine(result);      // 9

            operation = Multiply;           // теперь делегат указывает на метод Multiply
            result = operation(4, 5);       // фактически Multiply(4, 5)
            Console.WriteLine(result);      // 20

            int Add(int x, int y) => x + y;

            int Multiply(int x, int y) => x * y;

            Operation1 operation1 = Adds;
            Operation1 operation2 = new Operation1(Adds);

            int Adds(int x, int y) => x + y;

            Message1 message = Hello;
            message += HowAreYou;  // теперь message указывает на два метода
            message();              // вызываются оба метода - Hello и HowAreYou

            void Hello1() => Console.WriteLine("Hello");
            void HowAreYou() => Console.WriteLine("How are you?");
            //Объединение делегатов

            Message2 mes1 = Hello;
            Message2 mes2 = HowAreYou;
            Message2 mes3 = mes1 + mes2; // объединяем делегаты
            mes3(); // вызываются все методы из mes1 и mes2

            void Hello2() => Console.WriteLine("Hello");
            void HowAreYou1() => Console.WriteLine("How are you?");

            Message3 mes4 = Hello2;
            mes4.Invoke(); // Hello
            Operation2 op = Add1;
            int n = op.Invoke(3, 4);
            Console.WriteLine(n);   // 7

            void Hello3() => Console.WriteLine("Hello");
            int Add1(int x, int y) => x + y;
            //Обобщённые делегаты

            Operation<decimal, int> squareOperation = Square;
            decimal result1 = squareOperation(5);
            Console.WriteLine(result1);  // 25

            Operation<int, int> doubleOperation = Double;
            int result2 = doubleOperation(5);
            Console.WriteLine(result2);  // 10

            decimal Square(int n) => n * n;
            int Double(int n) => n + n;
        }
        delegate void Message(); // 1. Объявляем делегат
        delegate int Operation(int x, int y);
        delegate int Operation1(int x, int y);
        delegate void Message1();
        delegate void Message2();
        delegate int Operation2(int x, int y);
        delegate void Message3();
        delegate T Operation<T, K>(K val);


        class Welcome
        {
            public static void Print() => Console.WriteLine("Welcome");
        }
        class Hello
        {
            public void Display() => Console.WriteLine("Привет");
        }
    }
}
