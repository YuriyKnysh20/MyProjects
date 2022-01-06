using System;

namespace Anonymoustypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var User = new { Name = "Tom", Age = "20 "};
            Console.WriteLine(User);

            Person tom = new Person("Tom");
            int age = 34;
            var student = new { tom.Name, age }; // инициализатор с проекцией
            Console.WriteLine(student.Name);
            Console.WriteLine(student.age);
            //Массив анонимных типов

            var people = new[]
            {
             new {Name="Tom"},
             new {Name="Bob"}
             };
            foreach (var p in people)
            {
                Console.WriteLine(p.Name);
            }
        }
    }

 
    class Person
    {
        public string Name { get; set; }
        public Person(string name) => Name = name;
    }
}
