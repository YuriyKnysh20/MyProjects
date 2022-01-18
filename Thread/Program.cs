class Program
{
    static void Main(string[] args)
    {
        Counter counter = new Counter(5, 4);

        Thread myThread = new Thread(new ThreadStart(counter.Count));
        myThread.Start();
        //........................
    }
}

public class Counter
{
    private int x;
    private int y;

    public Counter(int _x, int _y)
    {
        this.x = _x;
        this.y = _y;
    }

    public void Count()
    {
        for (int i = 1; i < 9; i++)
        {
            Console.WriteLine("Второй поток:");
            Console.WriteLine(i * x * y);
            Thread.Sleep(400);
        }
    }
}