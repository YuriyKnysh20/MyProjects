
{
    Task[] tasks1 = new Task[3]
    {
        new Task(() => Console.WriteLine("First Task")),
        new Task(() => Console.WriteLine("Second Task")),
        new Task(() => Console.WriteLine("Third Task"))
    };
    foreach (var t in tasks1)
        t.Start();

    Task[] tasks2 = new Task[3];
    int j = 1;
    for (int i = 0; i < tasks2.Length; i++)
        tasks2[i] = Task.Factory.StartNew(() => Console.WriteLine($"Task {j++}"));

    Console.WriteLine("Завершение метода Main");

   
    Task<int> task1 = new Task<int>(() => Factorial(5));
    task1.Start();

    Console.WriteLine($"Факториал числа 5 равен {task1.Result}");

    Task<Book> task2 = new Task<Book>(() =>
    {
        return new Book { Title = "Война и мир", Author = "Л. Толстой" };
    });
    task2.Start();

    Book b = task2.Result;  // ожидаем получение результата
    Console.WriteLine($"Название книги: {b.Title}, автор: {b.Author}");
}

static int Factorial(int x)
{
    int result = 1;

    for (int i = 1; i <= x; i++)
    {
        result *= i;
    }

    return result;
}

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
}
