using System;

namespace Arithmeticoperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int z = x + 12; // 22
            

            int x1 = 10;
            int z1 = x1 - 6; // 4
            

        
            int x2 = 10;
            int z2 = x2 * 5; // 50



            int x3 = 10;
            int z3 = x3 / 5; // 2

            double a = 10;
            double b = 3;
            double c = a / b; // 3.33333333
            
            double z4 = 10 / 4; //результат равен 2
     
            double z5 = 10.0 / 4.0; //результат равен 2.5



            double x4 = 10.0;
            double z6 = x4 % 4.0; //результат равен 2
       




            int x5 = 5;
            int z7 = ++x5; // z1=6; x1=6
            Console.WriteLine($"{x5} - {z7}");

            int x6 = 5;
            int z8 = x6++; // z2=5; x2=6
            Console.WriteLine($"{x6} - {z8}");
           


            int x7 = 5;
            int z9 = --x7; // z1=4; x1=4
            Console.WriteLine($"{x7} - {z9}");

            int x8 = 5;
            int z10 = x8--; // z2=5; x2=4
            Console.WriteLine($"{x8} - {z10}");
         
            int a1 = 3;
            int b1 = 5;
            int c1 = 40;
            int d = c1-- - b1 * a1;    // a=3  b=5  c=39  d=25
            Console.WriteLine($"a={a1}  b={b1}  c={c1}  d={d}");
            
            int d1 = (c1--) - (b1 * a1);
            
 
            int a2 = 3;
            int b2 = 5;
            int c2 = 40;
            int d2 = (c2 - (--b2)) * a2;    // a=3  b=4  c=40  d=108
            Console.WriteLine($"a={a2}  b={b2}  c={c2}  d={d2}");

            
           int x9 = 10 / 5 * 2;
        }
    }
}
