using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Bob");
            person.Print();     // Bob
            Employee employee = new Employee("Tom", "Microsoft");
            employee.Print();   // Tom

            Employee1 tom = new Employee1("Tom", 22, "Microsoft");
        }
    }
    class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }
        public void Print()
        {
            Console.WriteLine(Name);
        }
    }

    class Employee : Person
    {
        public string Company { get; set; }
        public Employee(string name, string company)
            : base(name)
        {
            Company = company;
        }
    }
    //Конструкторы
    class Person1
    {
        string name;
        int age;

        public Person1(string name)
        {
            this.name = name;
            Console.WriteLine("Person(string name)");
        }
        public Person1(string name, int age) : this(name)
        {
            this.age = age;
            Console.WriteLine("Person(string name, int age)");
        }
    }
    class Employee1 : Person1
    {
        string company;

        public Employee1(string name, int age, string company) : base(name, age)
        {
            this.company = company;
            Console.WriteLine("Employee(string name, int age, string company)");
        }
    }
}
