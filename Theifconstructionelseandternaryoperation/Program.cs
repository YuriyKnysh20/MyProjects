using System;

namespace Theifconstructionelseandternaryoperation
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 8;
            int num2 = 6;
            if (num1 > num2)
            {
                Console.WriteLine($"Число {num1} больше числа {num2}");
            }
   

            int num3 = 8;
            int num4 = 6;
            if (num3 > num4)
                Console.WriteLine($"Число {num3} больше числа {num4}");

            // или так
            if (num1 > num2) Console.WriteLine($"Число {num3} больше числа {num4}");
  
            int num5 = 8;
            int num6 = 6;
            if (num5 > num6 && num5 == 8)
            {
                Console.WriteLine($"Число {num5} больше числа {num6}");
            }
          
            int num7 = 8;
            int num8 = 6;
            if (num7 > num8)
            {
                Console.WriteLine($"Число {num7} больше числа {num8}");
            }
            else
            {
                Console.WriteLine($"Число {num7} меньше числа {num8}");
            }

            int num9 = 8;
            int num10 = 6;
            if (num9 > num10)
                Console.WriteLine($"Число {num9} больше числа {num10}");
            else
                Console.WriteLine($"Число {num9} меньше числа {num10}");


            int num11 = 8;
            int num12 = 6;
            if (num11 > num12)
            {
                Console.WriteLine($"Число {num11} больше числа {num12}");
            }
            else if (num11 < num12)
            {
                Console.WriteLine($"Число {num11} меньше числа {num12}");
            }
            else
            {
                Console.WriteLine("Число num1 равно числу num2");
            }
  
            string name = "Alex";

            if (name == "Tom")
                Console.WriteLine("Вас зовут Tomas");
            else if (name == "Bob")
                Console.WriteLine("Вас зовут Robert");
            else if (name == "Mike")
                Console.WriteLine("Вас зовут Michael");
            else
                Console.WriteLine("Неизвестное имя");

            int x = 3;
            int y = 2;

            int z = x < y ? (x + y) : (x - y);
            Console.WriteLine(z);   // 1
        }
    }
}
