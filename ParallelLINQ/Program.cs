int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, };
var factorials = from n in numbers.AsParallel()
                 select Factorial(n);
foreach (var n in factorials)
    Console.WriteLine(n);
Console.ReadLine();

 
static int Factorial(int x)
{
    int result = 1;

    for (int i = 1; i <= x; i++)
    {
        result *= i;
    }
    Console.WriteLine($"Факториал числа {x} равен {result}");
    return result;
}
