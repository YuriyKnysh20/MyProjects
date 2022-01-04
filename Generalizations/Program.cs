using System;

namespace Generalizations
{
    class Program
    {
        static void Main(string[] args)
        {
            Person tom = new Person(546, "Tom"); // упаковка в значения int в тип Object
            Person bob = new Person("abc123", "Bob");

            int tomId = (int)tom.Id;        // Распаковка в тип int
            string bobId = (string)bob.Id;

            Console.WriteLine(tomId);   // 546
            Console.WriteLine(bobId);   // abc123

            Person<int> tom1 = new Person<int>(546, "Tom");  // упаковка не нужна
            Person<string> bob1 = new Person<string>("abc123", "Bob");

            int tom1Id = tom1.Id;      // распаковка не нужна
            string bob1Id = bob1.Id;  // преобразование типов не нужно

            Console.WriteLine(tom1Id);   // 546
            Console.WriteLine(bob1Id);   // abc123

            Person<int> tom2 = new Person<int>(546, "Tom");
            Person<int>.code = 1234;

            Person<string> bob2 = new Person<string>("abc", "Bob");
            Person<string>.code = "meta";

            Console.WriteLine(Person<int>.code);       // 1234
            Console.WriteLine(Person<string>.code);   // meta

            //Обобщённые методы
            int x = 7;
            int y = 25;
            Swap<int>(ref x, ref y); // или так Swap(ref x, ref y);
            Console.WriteLine($"x={x}    y={y}");   // x=25   y=7

            string s1 = "hello";
            string s2 = "bye";
            Swap<string>(ref s1, ref s2); // или так Swap(ref s1, ref s2);
            Console.WriteLine($"s1={s1}    s2={s2}"); // s1=bye   s2=hello

            void Swap<T>(ref T x, ref T y)
            {
                T temp = x;
                x = y;
                y = temp;
            }
        }
    }
    class Person
    {
        public object Id { get; }
        public string Name { get; }
        public Person(object id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    class Person<T>
    {
        //Статические поля
        public static T? code;
        public T Id { get; set; }
        public string Name { get; set; }
        public Person(T id, string name)
        {
            Id = id;
            Name = name;
        }
    }
   
}
