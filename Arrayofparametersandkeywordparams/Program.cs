using System;

namespace Arrayofparametersandkeywordparams
{
    class Program
    {
        static void Main(string[] args)
        {
            void Sum(params int[] numbers)
            {
                int result = 0;
                foreach (var n in numbers)
                {
                    result += n;
                }
                Console.WriteLine(result);
            }

            int[] nums = { 1, 2, 3, 4, 5 };
            Sum(nums);
            Sum(1, 2, 3, 4);
            Sum(1, 2, 3);
            Sum();

            void Sum1(int initialValue, params int[] numbers)
            {
                int result1 = initialValue;
                foreach (var n in numbers)
                {
                    result1 += n;
                }
                Console.WriteLine(result1);
            }

            int[] nums1 = { 1, 2, 3, 4, 5 };
            Sum1(10, nums1);  // число 10 - передается параметру initialValue
            Sum1(1, 2, 3, 4);
            Sum1(1, 2, 3);
            Sum1(20);

            void Sum2(int[] numbers, int initialValue)
            {
                int result2 = initialValue;
                foreach (var n in numbers)
                {
                    result2 += n;
                }
                Console.WriteLine(result2);
            }

            int[] nums2 = { 1, 2, 3, 4, 5 };
            Sum2(nums2, 10);
        }
    }
}
