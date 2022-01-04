using System;

namespace Abstractclassesandclassmembers
{
    class Program
    {
        static void Main(string[] args)
        {
            Transport car = new Car();
            Transport ship = new Ship();
            Transport aircraft = new Aircraft();

            car.Move();         // машина едет
            ship.Move();        // корабль плывет
            aircraft.Move();    // самолет летит

            var rectanle = new Rectangle { Width = 20, Height = 20 };
            var circle = new Circle { Radius = 200 };
            PrintShape(rectanle); // Perimeter: 80   Area: 400
            PrintShape(circle); // Perimeter: 1256  Area: 125600

            void PrintShape(Shape shape)
            {
                Console.WriteLine($"Perimeter: {shape.GetPerimeter()}  Area: {shape.GetArea()}");
            }
        }
    }

    abstract class Transport
    {
        public abstract void Move();
        // абстрактное свойство для хранения скорости
        public abstract int Speed { get; set; }
    }
    // класс корабля
    class Ship : Transport
    {
        // мы должны реализовать все абстрактные методы и свойства базового класса
        public override void Move()
        {
            Console.WriteLine("Корабль плывет");
        }
        int speed;
        public override int Speed
        {
            get => speed;
            set => speed = value;
        }
    }
    // класс самолета
    class Aircraft : Transport
    {
        public override void Move()
        {
            Console.WriteLine("Самолет летит");
        }
        public override int Speed { get; set; }
    }
    // класс машины
    class Car : Transport
    {
        public override void Move()
        {
            Console.WriteLine("Машина едет");
        }
        public override int Speed { get; set; }
    }

    // абстрактный класс фигуры
    abstract class Shape
    {
        // абстрактный метод для получения периметра
        public abstract double GetPerimeter();
        // абстрактный метод для получения площади
        public abstract double GetArea();
    }
    // производный класс прямоугольника
    class Rectangle : Shape
    {
        public float Width { get; set; }
        public float Height { get; set; }

        // переопределение получения периметра
        public override double GetPerimeter() => Width * 2 + Height * 2;
        // переопрелеление получения площади
        public override double GetArea() => Width * Height;
    }
    // производный класс окружности
    class Circle : Shape
    {
        public double Radius { get; set; }

        // переопределение получения периметра
        public override double GetPerimeter() => Radius * 2 * 3.14;
        // переопрелеление получения площади
        public override double GetArea() => Radius * Radius * 3.14;
    }
}
