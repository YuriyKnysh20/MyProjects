using System;

namespace AssignmentOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 23;
      
            int a, b, c;
            a = b = c = 34;
      
            int a1, b1, c1;
            a1 = b1 = c1 = 34 * 2 / 4; // 17

            int a2 = 10;
            a2 += 10;        // 20
            a2 -= 4;         // 16
            a2 *= 2;         // 32
            a2 /= 8;         // 4
            a2 <<= 4;      // 64
            a2 >>= 2;      // 16

            int a3 = 8;
            int b3 = 6;
            int c3 = a3 += b3 -= 5;    // 9
        }
    }
}
