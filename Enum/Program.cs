using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            DayTime now = DayTime.Evening;

            PrintMessage(now);                   // Добрый вечер
            PrintMessage(DayTime.Afternoon);    // Добрый день
            PrintMessage(DayTime.Night);        // Доброй ночи

            void PrintMessage(DayTime dayTime)
            {
                switch (dayTime)
                {
                    case DayTime.Morning:
                        Console.WriteLine("Доброе утро");
                        break;
                    case DayTime.Afternoon:
                        Console.WriteLine("Добрый день");
                        break;
                    case DayTime.Evening:
                        Console.WriteLine("Добрый вечер");
                        break;
                    case DayTime.Night:
                        Console.WriteLine("Доброй ночи");
                        break;
                }
            }


            DoOperation(10, 5, Operation.Add);          // 15
            DoOperation(10, 5, Operation.Subtract);     // 5
            DoOperation(10, 5, Operation.Multiply);     // 50
            DoOperation(10, 5, Operation.Divide);       // 2

            void DoOperation(double x, double y, Operation op)
            {
                double result = op switch
                {
                    Operation.Add => x + y,
                    Operation.Subtract => x - y,
                    Operation.Multiply => x * y,
                    Operation.Divide => x / y
                };
                Console.WriteLine(result);
            }

        }
         enum DayTime
        {
            Morning,
            Afternoon,
            Evening,
            Night
        }

       
        enum Operation
        {
            Add,
            Subtract,
            Multiply,
            Divide
        }

        enum Time : byte
        {
            Morning,
            Afternoon,
            Evening,
            Night
        }

        enum Time1
        {
            Morning=4,
            Afternoon,
            Evening,
            Night
        }

    }
    
}
