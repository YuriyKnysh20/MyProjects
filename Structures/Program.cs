using System;

namespace Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            Person tom = new Person();  // вызов конструктора
                                        // или так 
                                        // Person tom = new();
            tom.name = "Tom";   // изменяем значение по умолчанию в поле name

            tom.Print();    // Имя: Tom  Возраст: 0
            //Инициализация
            Person tom1;         // не вызываем конструктор
                                // инициализация полей
            tom1.name = "Sam";
            tom1.age = 37;

            tom1.Print();    // Имя: Sam  Возраст: 37

            Person1 tom2 = new();
            Person1 bob1 = new("Bob");
            Person1 sam1 = new("Sam", 25);

            tom2.Print();    // !!!! Имя:   Возраст: 0
            bob1.Print();    // Имя: Bob  Возраст: 1 
            sam1.Print();    // Имя: Sam  Возраст: 25

            Person tom3 = new Person { name = "Tom", age = 22 };

            tom3.Print();    // Имя: Tom  Возраст: 22
            //Копирование структуры
            /*
            Person tom4 = new Person { name = "Tom", age = 22 };
            Person bob = tom4 with { name = "Bob" };
            bob.Print();    // Имя: Bob  Возраст: 22
            */
        }
          struct Person
          {
            public string name;
            public int age;

            public void Print()
            {
                Console.WriteLine($"Имя: {name}  Возраст: {age}");
            }
          }

        struct Person1
        {
            public string name;
            public int age;

            public Person1(string name = "Tom", int age = 1)
            {
                this.name = name;
                this.age = age;
            }
            public void Print() => Console.WriteLine($"Имя: {name}  Возраст: {age}");
        }

    }
}
