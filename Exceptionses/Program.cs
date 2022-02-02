object[] numbers2 = new object[] { 1, 2, 3, 4, 5, "hello" };

var factorials = from n in numbers2.AsParallel()
                 let x = (int)n
                 select Factorial(x);
try
{
    factorials.ForAll(n => Console.WriteLine(n));
}
catch (AggregateException ex)
{
    foreach (var e in ex.InnerExceptions)
    {
        Console.WriteLine(e.Message);
    }
}
static int Factorial(int x)
{
    int result = 1;

    for (int i = 1; i <= x; i++)
    {
        result *= i;
    }
    Console.WriteLine($"Факториал числа {x} равен {result}");
    Thread.Sleep(1000);
    return result;
}