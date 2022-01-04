using System;

namespace Staticmembersandthestaticmodifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Person bob = new(68);
            bob.СheckAge();     // Уже на пенсии

            Person tom = new(37);
            tom.СheckAge();     // Сколько лет осталось до пенсии: 28

            // получение статического поля
            Console.WriteLine(Person.retirementAge); // 65
                                                     // изменение статического поля
            Person.retirementAge = 67;

            Person bob1 = new(68);
            bob1.СheckAge();

            Console.WriteLine(Person.RetirementAge); // 65

            Person bob2 = new(68);
            Person.CheckRetirementStatus(bob2);

            Console.WriteLine(Operations.Add(5, 4));         // 9
            Console.WriteLine(Operations.Subtract(5, 4));    // 1
            Console.WriteLine(Operations.Multiply(5, 4));    // 20
        }
    }
  
    class Person
    {
        int age;
        public static int retirementAge = 65;
        public Person(int age)
        {
            this.age = age;
        }
        public void СheckAge()
        {
            if (age >= retirementAge)
                Console.WriteLine("Уже на пенсии");
            else
                Console.WriteLine($"Сколько лет осталось до пенсии: {retirementAge - age}");
        }
        //Статические свойства

        public static int RetirementAge
        {
            get { return retirementAge; }
            set { if (value > 1 && value < 100) retirementAge = value; }
        }

        public int Age { get; set; }
        public static void CheckRetirementStatus(Person person)
        {
            if (person.Age >= retirementAge)
                Console.WriteLine("Уже на пенсии");
            else
                Console.WriteLine($"Сколько лет осталось до пенсии: {retirementAge - person.Age}");
        }

        //Статический конструктор

        static Person()
        {
            if (DateTime.Now.Year == 2022)
                retirementAge = 65;
            else
                retirementAge = 67;
        }

    }
 
    static class Operations
    {
        public static int Add(int x, int y) => x + y;
        public static int Subtract(int x, int y) => x - y;
        public static int Multiply(int x, int y) => x * y;
    }
}
