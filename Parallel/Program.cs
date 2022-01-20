
{
    Parallel.Invoke(Display,
        () => {
            Console.WriteLine($"Выполняется задача {Task.CurrentId}");
            Thread.Sleep(3000);
        },
        () => Factorial(5));

    Parallel.For(1, 10, Factorial);
    ParallelLoopResult result = Parallel.ForEach<int>(new List<int>() { 1, 3, 5, 8 },
                Factorial);
}

static void Display()
{
    Console.WriteLine($"Выполняется задача {Task.CurrentId}");
    Thread.Sleep(3000);
}

static void Factorial(int x)
{
    int result = 1;

    for (int i = 1; i <= x; i++)
    {
        result *= i;
    }
    Console.WriteLine($"Выполняется задача {Task.CurrentId}");
    Thread.Sleep(3000);
    Console.WriteLine($"Результат {result}");
}
