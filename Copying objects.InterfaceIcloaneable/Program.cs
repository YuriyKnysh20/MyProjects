using System;

namespace Copying_objects.InterfaceIcloneable
{
    class Program
    {
        static void Main(string[] args)
        {
            var tom = new Person("Tom", 23,new Company("Amazon"));
            var bob = tom;
            bob.Name = "Bob";
            Console.WriteLine(tom.Name); // Bob

            var tom1 = new Person("Tom", 23,new Company("Apple"));
            var bob1 = (Person)tom1.Clone();
            bob1.Name = "Bob";
            Console.WriteLine(tom1.Name); // Tom

            var tom2 = new Person("Tom", 23, new Company("Microsoft"));
            var bob2 = (Person)tom2.Clone();
            bob2.Work.Name = "Google";
            Console.WriteLine(tom2.Work.Name); //  Microsoft
        }
    }
    class Person:ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Company Work { get; set; }
        public Person(string name, int age,Company company)
        {
            Name = name;
            Age = age;
            Work= company;
        }
        /*
        public object Clone()
        {
            return new Person(Name,Age);
        }
        */
       // public object Clone()=> MemberwiseClone(); Использование неглубокого копирования
        public object Clone() => new Person(Name, Age, new Company(Work.Name));
    }
    class Company
    {
        public string Name { get; set; }
        public Company(string name) => Name = name;
    }
    public interface ICloneable
    {
        object Clone();
    }
   
   
}
