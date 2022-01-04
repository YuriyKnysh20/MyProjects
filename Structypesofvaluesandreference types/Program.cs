using System;

namespace Structypesofvaluesandreference_types
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate(5);

           // State state1 = new State(); // State - структура, ее данные размещены в стеке
           // Country country1 = new Country(); // Country - класс, в стек помещается ссылка на адрес в хипе
                                              // а в хипе располагаются все данные объекта country1

            State state1 = new State(); // Структура State
            State state2 = new State();
            state2.x = 1;
            state2.y = 2;
            state1 = state2;
            state2.x = 5; // state1.x=1 по-прежнему
            Console.WriteLine(state1.x); // 1
            Console.WriteLine(state2.x); // 5

            Country country1 = new Country(); // Класс Country
            Country country2 = new Country();
            country2.x = 1;
            country2.y = 4;
            country1 = country2;
            country2.x = 7; // теперь и country1.x = 7, так как обе ссылки и country1 и country2 
                            // указывают на один объект в хипе
            Console.WriteLine(country1.x); // 7
            Console.WriteLine(country2.x); // 7
            //Ссылочные типы внутри типов значений

            State state3 = new State();
            State state4 = new State();
            /*
            state3.country = new Country();
            state4.country.x = 5;
            state4 = state4;
            state2.country.x = 8; // теперь и state1.country.x=8, так как state1.country и state2.country
                                  // указывают на один объект в хипе
            Console.WriteLine(state3.country.x); // 8
            Console.WriteLine(state4.country.x); // 8
            */


            Person p = new Person { name = "Tom", age = 23 };
            ChangePerson(p);

            Console.WriteLine(p.name); // Alice
            Console.WriteLine(p.age); // 23

            void ChangePerson(Person person)
            {
                // сработает
                person.name = "Alice";
                // сработает только в рамках данного метода
                person = new Person { name = "Bill", age = 45 };
                Console.WriteLine(person.name); // Bill
            }


        
    }

        static void Calculate(int t)
        {
            int x = 6;
            int y = 7;
            int z = y + t;
        }

        struct State
        {
            public int x;
            public int y;
            //public Country country = new(); // выделение памяти для объекта Country
        }
        class Country
        {
            public int x;
            public int y;
        }
        class Person
        {
            public string name = "";
            public int age;
        }
    }
}
