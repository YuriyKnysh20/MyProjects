using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HelloApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await foreach (var number in GetNumbersAsync())
            {
                Console.WriteLine(number);
            }
        }

        public static async IAsyncEnumerable<int> GetNumbersAsync()
        {
            for (int i = 0; i < 10; i++)
            {
                await Task.Delay(100);
                yield return i;
            }
        }
    }
}
