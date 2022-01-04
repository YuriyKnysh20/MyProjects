using System;

namespace Catchblock
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x = 5;
                int y = x / 0;
                Console.WriteLine($"Результат: {y}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Возникло исключение DivideByZeroException");
            }

            try
            {
                int x1 = 5;
                int y1 = x1 / 0;
                Console.WriteLine($"Результат: {y1}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Возникло исключение {ex.Message}");
            }

            int x2 = 1;
            int y2 = 0;

            try
            {
                int result1 = x2 / y2;
                int result2 = y2 / x2;
            }
            catch (DivideByZeroException) when (y2 == 0)
            {
                Console.WriteLine("y не должен быть равен 0");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
