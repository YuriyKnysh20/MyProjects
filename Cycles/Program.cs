using System;

namespace Cycles
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int s = 1; s < 4; s++)
            {
                Console.WriteLine(s);
            }

            for (int i4 = 1, j = 1; i4 < 10; i4++, j++)
                Console.WriteLine($"{i4 * j}");

            int i5 = 6;
            do
            {
                Console.WriteLine(i5);
                i5--;
            }
            while (i5 > 0);

            int i6 = -1;
            do
            {
                Console.WriteLine(i6);
                i6--;
            }
            while (i6 > 0);

            int i7 = 6;

            while (i7 > 0)
            {
                Console.WriteLine(i7);
                i7--;
            }

            foreach (char c in "Tom")
            {
                Console.WriteLine(c);
            }

            for (int k = 0; k < 9; k++)
            {
                if (k == 5)
                    break;
                Console.WriteLine(k);
            }

            for (int l = 0; l < 9; l++)
            {
                if (l == 5)
                    continue;
                Console.WriteLine(l);
            }

            for (int q = 1; q < 10; q++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.Write($"{q * j} \t");
                }
                Console.WriteLine();
            }
        }
    }
}
