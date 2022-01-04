using System;

namespace PassingparametersbyreferenceandvalueOutputparameters
{
    class Program
    {
        static void Main(string[] args)
        {
            void Increment(int n)
            {
                n++;
                Console.WriteLine($"Число в методе Increment: {n}");
            }

            int number = 5;
            Console.WriteLine($"Число до метода Increment: {number}");
            Increment(number);
            Console.WriteLine($"Число после метода Increment: {number}");

            void Increment1(ref int n)
            {
                n++;
                Console.WriteLine($"Число в методе Increment: {n}");
            }

            int number1 = 5;
            Console.WriteLine($"Число до метода Increment: {number}");
            Increment1(ref number1);
            Console.WriteLine($"Число после метода Increment: {number}");

            void Sum(int x, int y, out int result)
            {
                result = x + y;
            }

            int number2;

            Sum(10, 15, out number2);

            Console.WriteLine(number2);   // 25

            void GetRectangleData(int width, int height, out int rectArea, out int rectPerimetr)
            {
                rectArea = width * height;       // площадь прямоугольника - произведение ширины на высоту
                rectPerimetr = (width + height) * 2; // периметр прямоугольника - сумма длин всех сторон  
            }

            int area;
            int perimetr;

            GetRectangleData(10, 20, out area, out perimetr);

            Console.WriteLine($"Площадь прямоугольника: {area}");       // 200
            Console.WriteLine($"Периметр прямоугольника: {perimetr}");   // 60

            void GetRectangleData1(in int width, in int height, out int rectArea, out int rectPerimetr)
            {
                //width = 25; // нельзя изменить, так как width - входной параметр
                rectArea = width * height;
                rectPerimetr = (width + height) * 2;
            }

            int w = 10;
            int h = 20;
            GetRectangleData1(w, h, out var area1, out var perimetr1);

            Console.WriteLine($"Площадь прямоугольника: {area1}");       // 200
            Console.WriteLine($"Периметр прямоугольника: {perimetr1}");   // 60
        }
    }
}
