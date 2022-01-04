using System;

namespace Conditionalexpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 4;
            bool c = a == b; // false

            int a1 = 10;
            int b1 = 4;
            bool c1 = a1 != b1;    // true
            bool d1 = a1 != 10;     // false


            int e = 10;
            int g = 4;
            bool c2 = e < g; // false

            int d = 10;
            int k = 4;
            bool c3 = d > k;     // true
            bool d2 = d > 25;    // false


            int a2 = 10;
            int b2 = 4;
            bool c4 = a2 <= b2;     // false
            bool d3 = a2 <= 25;    // true


            int q = 10;
            int w = 4;
            bool c5 = q >= w;     // true
            bool d4 = q >= 25;    // false
    
            bool x1 = (5 > 6) | (4 < 6); // 5 > 6 - false, 4 < 6 - true, поэтому возвращается true
            bool x2 = (5 > 6) | (4 > 6); // 5 > 6 - false, 4 > 6 - false, поэтому возвращается false
           
 
            bool y = (5 > 6) & (4 < 6); // 5 > 6 - false, 4 < 6 - true, поэтому возвращается false
            bool x3 = (5 < 6) & (4 < 6); // 5 < 6 - true, 4 < 6 - true, поэтому возвращается true


            bool x4 = (5 > 6) || (4 < 6); // 5 > 6 - false, 4 < 6 - true, поэтому возвращается true
            bool x5 = (5 > 6) || (4 > 6); // 5 > 6 - false, 4 > 6 - false, поэтому возвращается false


            bool x6 = (5 > 6) && (4 < 6); // 5 > 6 - false, 4 < 6 - true, поэтому возвращается false
            bool x7 = (5 < 6) && (4 < 6); // 5 < 6 - true, 4 < 6 - true, поэтому возвращается true
            

            bool a3 = true;
            bool b3 = !a3;    // false
  
            bool x8 = (5 > 6) ^ (4 < 6); // 5 > 6 - false, 4 < 6 - true, поэтому возвращается true
            bool x9 = (50 > 6) ^ (4 / 2 < 3); // 50 > 6 - true, 4/2 < 3 - true, поэтому возвращается false
        }
    }
}
