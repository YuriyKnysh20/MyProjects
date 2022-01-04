using System;

namespace Constructorsinitializersanddeconstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Person tom = new Person();  // Создание объекта класса Person

            tom.Print();    // Имя: Tom  Возраст: 37

            // вызов 1-ого конструктора без параметров
            Person bob = new Person("Bob");     //вызов 2-ого конструктора с одним параметром
            Person sam = new Person("Sam", 25); // вызов 3-его конструктора с двумя параметрами

            tom.Print();          // Имя: Неизвестно  Возраст: 18
            bob.Print();          // Имя: Bob  Возраст: 18
            sam.Print();          // Имя: Sam  Возраст: 25

            Person1 sam1 = new("Sam", 25);
            sam1.Print();          // Имя: Sam  Возраст: 25
            //Инициализаторы

            Person3 tom1 = new Person3 { name = "Tom", company = { title = "Microsoft" } };
            tom1.Print();          // Имя: Tom  Компания: Microsoft

            Person4 person = new Person4("Tom", 33);

            (string name, int age) = person;

            Console.WriteLine(name);    // Tom
            Console.WriteLine(age);     // 33
        }

    }



    class Person
    {
        //Конструкторы

        public string name;
        public int age;
        public Person() { name = "Неизвестно"; age = 18; }      // 1 конструктор
        public Person(string n) { name = n; age = 18; }         // 2 конструктор
        public Person(string n, int a) { name = n; age = a; }   // 3 конструктор

        public void Print()
        {
            Console.WriteLine($"Имя: {name}  Возраст: {age}");
        }
    }
  class Person1 
  {
    public string name;
    public int age;
    public Person1() { name = "Неизвестно"; age = 18; }
    public Person1(string name) { this.name = name; age = 18; }
    public Person1(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public void Print() => Console.WriteLine($"Имя: {name}  Возраст: {age}");
  }

    class Person2
    {
        public string name;
        public int age;
        public Person2() : this("Неизвестно")    // первый конструктор
        { }
        public Person2(string name) : this(name, 18) // второй конструктор
        { }
        public Person2(string name, int age)     // третий конструктор
        {
            this.name = name;
            this.age = age;
        }
        public void Print() => Console.WriteLine($"Имя: {name}  Возраст: {age}");
    }

    class Person3
    {
        public string name;
        public Company company;
        public Person3()
        {
            name = "Undefined";
            company = new Company();
        }
        public void Print() => Console.WriteLine($"Имя: {name}  Компания: {company.title}");
    }

    class Company
    {
        public string title = "Unknown";
    }
    //Деконструктор
    class Person4
    {
        string name;
        int age;
        public Person4(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Deconstruct(out string personName, out int personAge)
        {
            personName = name;
            personAge = age;
        }
    }
}

