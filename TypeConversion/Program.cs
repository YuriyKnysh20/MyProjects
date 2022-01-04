using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Tom", "Microsoft");
            Person person = employee;   // преобразование от Employee к Person

            Console.WriteLine(person.Name);

            Person bob = new Client("Bob", "ContosoBank");   // преобразование от Client к Person

            object person1 = new Employee("Tom", "Microsoft");  // от Employee к object
            object person2 = new Client("Bob", "ContosoBank");  // от Client к object
            object person3 = new Person("Sam");                 // от Person к object

            Employee employee1 = new Employee("Tom", "Microsoft");
            Person person4 = employee1;   // преобразование от Employee к Person

            Person person5 = new Person("Tom");
            Employee? employee2 = person5 as Employee;
            if (employee2 == null)
            {
                Console.WriteLine("Преобразование прошло неудачно");
            }
            else
            {
                Console.WriteLine(employee2.Company);
            }

            Person person6 = new Person("Tom");
            if (person6 is Employee employee3)
            {
                Console.WriteLine(employee3.Company);
            }
            else
            {
                Console.WriteLine("Преобразование не допустимо");
            }
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
            Console.WriteLine($"Person {Name}");
        }
    }

    class Employee : Person
    {
        public string Company { get; set; }
        public Employee(string name, string company) : base(name)
        {
            Company = company;
        }
    }

    class Client : Person
    {
        public string Bank { get; set; }
        public Client(string name, string bank) : base(name)
        {
            Bank = bank;
        }
    }
}
