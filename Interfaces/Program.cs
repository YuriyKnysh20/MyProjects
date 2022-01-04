using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(IMovable.minSpeed);   // 0
            Console.WriteLine(IMovable.MaxSpeed);   // 60
            IMovable.MaxSpeed = 65;
            Console.WriteLine(IMovable.MaxSpeed);   // 65
            double time = IMovable.GetTime(500, 10);
            Console.WriteLine(time);    // 50
        }
    }
    interface IMovable
    {
        // константа
        const int minSpeed = 0;     // минимальная скорость
                                    // статическая переменная
        static int maxSpeed = 60;   // максимальная скорость
                                    // метод
        void Move();                // движение
                                    // свойство
        string Name { get; set; }   // название

        delegate void MoveHandler(string message);  // определение делегата для события
                                                    // событие
        event MoveHandler MoveEvent;    // событие движения

        // реализация метода по умолчанию
        void Move1() => Console.WriteLine("Walking");
        static double GetTime(double distance, double speed) => distance / speed;
        // реализация свойства по умолчанию
        // свойство только для чтения
        static int MaxSpeed
        {
            get => maxSpeed;
            set
            {
                if (value > 0) maxSpeed = value;
            }
        }
    }

    
}
