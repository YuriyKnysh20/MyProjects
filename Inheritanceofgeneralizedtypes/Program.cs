using System;

namespace Inheritanceofgeneralizedtypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person<string> person1 = new Person<string>("34");
            Person<int> person3 = new UniversalPerson<int>(45);
            UniversalPerson<int> person2 = new UniversalPerson<int>(33);
            Console.WriteLine(person1.Id);
            Console.WriteLine(person2.Id);
            Console.WriteLine(person3.Id);
        }
    }
 
    class Person<T>
    {
        public T Id { get; }
        public Person(T id)
        {
            Id = id;
        }
    }

    class UniversalPerson<T> : Person<T>
    {
        public UniversalPerson(T id) : base(id) { }
    }
    class MixedPerson<T, K> : Person<T>
    where K : struct
  {
    public K Code { get; set; }
    public MixedPerson(T id, K code) : base(id)
    {
        Code = code;
    }
  }

}


