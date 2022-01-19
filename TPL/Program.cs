using System;
using System.Threading;

namespace TaskApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task = new Task(Display);
            task.Start();

            Console.WriteLine("Завершение метода Main");           
        }

        static void Display()
        {
            Console.WriteLine("Начало работы метода Display");

            Console.WriteLine("Завершение работы метода Display");
        }
    }
}
