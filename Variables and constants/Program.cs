using System;

namespace Variables_and_constants
{
   
    class Program
    {
        static void Main(string[] args)
        {
            //Инициализация константы
            const string NAME = "Tom";  // определяем константу

            string name;
            string Name;
           
            //Присвоим переменной значение

            name = "Tom";
            Console.WriteLine(name);    // Tom

            name = "Bob";       // меняем значение переменной
            Console.WriteLine(name);    // Bob
        }
    }
}
