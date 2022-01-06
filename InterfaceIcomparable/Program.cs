using System;

namespace InterfaceIcomparable
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var tom = new Person("Tom", 37);
            var bob = new Person("Bob", 41);
            var sam = new Person("Sam", 25);

            Person[] people = { tom, bob, sam };
            Array.Sort(people);

            foreach (Person person in people)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
          
        }
    }
 
    class Person2
    {
        public string Name { get; }
        public int Age { get; set; }
        public Person2(string name, int age)
        {
            Name = name; Age = age;
        }
    }
    class Person : IComparable
    {
        public string Name { get; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name; Age = age;
        }
        public int CompareTo(object? o)
        {
            if (o is Person person) return Name.CompareTo(person.Name);
            else throw new ArgumentException("Некорректное значение параметра");
        }
    }
    //Упрощённое применение интерфейса
    class Person1 : IComparable<Person>
    {
        public string Name { get; }
        public int Age { get; set; }
        public Person1(string name, int age)
        {
            Name = name; Age = age;
        }
        public int CompareTo(Person? person)
        {
            if (person is null) throw new ArgumentException("Некорректное значение параметра");
            return Name.CompareTo(person.Name);
        }
    }
}
