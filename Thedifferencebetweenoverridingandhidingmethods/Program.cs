using System;

namespace Thedifferencebetweenoverridingandhidingmethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Person tom = new Employee("Tom", "Microsoft");
            tom.Print();        // Tom работает в Microsoft
            Person tom = new Employee("Tom", "Microsoft");
            tom.Print();        // Tom
        }
    }
    //Переопределние
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
        public Employee(string name, string company)
            : base(name)
        {
            Company = company;
        }

        public override void Print()
        {
            Console.WriteLine($"{Name} работает в {Company}");
        }
    }
    //Скрытие

    class Person1
    {
        public string Name { get; set; }
        public Person1(string name)
        {
            Name = name;
        }

        public void Print()
        {
            Console.WriteLine(Name);
        }
    }

    class Employee1: Person1
    {
        public string Company { get; set; }
        public Employee1(string name, string company)
                : base(name)
        {
            Company = company;
        }
        public new void Print()
        {
            Console.WriteLine($"{Name} работает в {Company}");
        }
    }
}
