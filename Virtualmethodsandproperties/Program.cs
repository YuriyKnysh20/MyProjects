using System;

namespace Virtualmethodsandproperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Person bob = new Person("Bob");
            bob.Print(); // вызов метода Print из класса Person

            Employee tom = new Employee("Tom", "Microsoft");
            tom.Print(); // вызов метода Print из класса Person
            Person bob1 = new Person("Bob");
            bob.Print(); // вызов метода Print из класса Person

            Employee1 tom1 = new Employee1("Tom", "Microsoft");
            tom1.Print(); // вызов метода Print из класса Employee

            Person1 bob2 = new Person1("Bob");
            Console.WriteLine(bob2.Age); // 1

            Employee2 tom2 = new Employee2("Tom", "Microsoft");
            Console.WriteLine(tom2.Age); // 18
            tom2.Age = 22;
            Console.WriteLine(tom2.Age); // 22
            tom2.Age = 12;
            Console.WriteLine(tom2.Age); // 22
        }
    }
    class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }
        public virtual void Print()
        {
            Console.WriteLine(Name);
        }
      
    }
    class Employee : Person
    {
        public string Company { get; set; }
        public Employee(string name, string company) : base(name)
        {
            Company = company;
        }
        public override sealed void Print()
        {
            Console.WriteLine($"{Name} работает в {Company}");
        }
    }
    class Employee1 : Person
    {
        public string Company { get; set; }
        public Employee1(string name, string company)
            : base(name)
        {
            Company = company;
        }
        public override void Print()
        {
            Console.WriteLine($"{Name} работает в {Company}");
        }
    }

    class Person1
    {
        int age = 1;
        public virtual int Age
        {
            get => age;
            set { if (value > 0 && value < 110) age = value; }
        }
        public string Name { get; set; }
        public Person1(string name)
        {
            Name = name;
        }
        public virtual void Print() => Console.WriteLine(Name);
    }
    class Employee2 : Person1
    {
        public override int Age
        {
            get => base.Age;
            set { if (value > 17 && value < 110) base.Age = value; }
        }
        public string Company { get; set; }
        public Employee2(string name, string company)
            : base(name)
        {
            Company = company;
            base.Age = 18; // возраст для работников по умолчанию
        }
    }
}
