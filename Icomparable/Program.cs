using System;
using System.Collections.Generic;

namespace IComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            var alice = new Person("Alice", 41);
            var michael = new Person("Michael", 37);
            var kate = new Person("Kate", 25);
           
            Person[] people1 = { alice, michael, kate };
            Array.Sort<Person>(people1, new PeopleComparer());

            foreach (Person person in people1)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
    class PeopleComparer : IComparer<Person>
    {
        public int Compare(Person? p1, Person? p2)
        {
            if (p1 is null || p2 is null)
                throw new ArgumentException("Некорректное значение параметра");
            return p1.Name.Length - p2.Name.Length;
        }
    }
 
    class Person
    {
        public string Name { get; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name; Age = age;
        }
    }
}
