using System;

namespace Transformationsofbasicdatatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 4;
            int b = a + 70;
   
            // byte a = 4;
            //byte b = a + 70;  // ошибка
           
            byte a1 = 4;
            byte b1 = (byte)(a1 + 70);

            byte a2 = 4;             // 0000100
            ushort b2 = a;   // 000000000000100

            ushort a3 = 4;
            byte b3 = (byte)a3;
       
            byte a4 = 4;             // 0000100
            ushort b4 = a4;   // 000000000000100
  
            sbyte a5 = 4;            // 0000100
            short b5 = a5;    // 000000000000100
       

            sbyte a6 = -4;           // 1111100
            short b6 = a6;    // 111111111111100
            //Явные преобразования

            int a7 = 4;
            int b7 = 6;
            byte c = (byte)(a7 + b7);

            double a8 = 4.0;
            decimal b8 = (decimal)a8;
            //Потеря данных
            int a9 = 33;
            int b9 = 600;
            byte c1 = (byte)(a + b);
            Console.WriteLine(c1);   // 121

            try
            {
                int d = 33;
                int e = 600;
                byte f = checked((byte)(d + e));
                Console.WriteLine(f);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
