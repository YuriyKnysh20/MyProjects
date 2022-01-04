using System;

namespace Literals
{
    class Program
    {
        static void Main(string[] args)
        {
            //Логические литералы

            Console.WriteLine(true);
            Console.WriteLine(false);
            //Целочисленные литералы
            Console.WriteLine(-11);
            Console.WriteLine(5);
            Console.WriteLine(505);

            Console.WriteLine(0b11);        // 3
            Console.WriteLine(0b1011);      // 11
            Console.WriteLine(0b100001);    // 33
            
            Console.WriteLine(0x0A);    // 10
            Console.WriteLine(0xFF);    // 255
            Console.WriteLine(0xA1);    // 161

            //Вещественные литералы
            float a = 3.14f;
            double b = 100.001;
            float c = -0.38f;

            Console.WriteLine(3.2e3);   // по сути равно 3.2 * 10<sup>3</sup> = 3200
            Console.WriteLine(1.2E-1);  // равно 1.2 * 10<sup>-1</sup> = 0.12
            //Символьные литералы

            Console.WriteLine('2');
            Console.WriteLine('A');
            Console.WriteLine('T');

            Console.WriteLine('\x78');    // x
            Console.WriteLine('\x5A');    // Z

            //Строковые литералы

            Console.WriteLine("hello");
            Console.WriteLine("фыва");
            Console.WriteLine("hello word");

            Console.WriteLine("Компания \"Рога и копыта\"");

            Console.WriteLine("Привет \nмир");
        }
    }
}
