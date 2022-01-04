using System;

namespace Features
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            Console.WriteLine(person.Age);  // 1
                                            // изменяем значение свойства
            person.Age = 37;
            Console.WriteLine(person.Age);  // 37
                                            // пробуем передать недопустимое значение
            person.Age = -23;               // Возраст должен быть в диапазоне от 1 до 120
            Console.WriteLine(person.Age);  // 37 - возраст не изменился

            Person1 person1 = new Person1();

            // свойство для чтения - можно получить значение
            Console.WriteLine(person1.Name);  // Tom
                                             // но нельзя установить
                                             // person.Name = "Bob";    // ! Ошибка

            // свойство для записи - можно устновить значение
            person1.Age = 37;
            // но нелзя получить
            // Console.WriteLine(person.Age);  // ! Ошибка

            person1.Print();
            Person2 tom1 = new Person2();

            Console.WriteLine(tom1.Name);    // Tom
            Console.WriteLine(tom1.Age);    // 37

            Person4 person2 = new();
            //person.Name = "Bob";    //! Ошибка - после инициализации изменить значение нельзя

            Console.WriteLine(person2.Name); // Undefined
        }
    }
    class Person
    {
        private string name = "Undefined";

        public string Name
        {
            get
            {
                return name;    // возвращаем значение свойства
            }
            set
            {
                name = value;   // устанавливаем новое значение свойства
            }
        }
        int age = 1;
        public int Age
        {
            set
            {
                if (value < 1 || value > 120)
                    Console.WriteLine("Возраст должен быть в диапазоне от 1 до 120");
                else
                    age = value;
            }
            get { return age; }
        }
    }

    class Person1
    {
        string name = "Tom";
        int age = 1;
        // свойство только для записи
        public int Age
        {
            set { age = value; }
        }
        // свойство только для чтения
        public string Name
        {
            get { return name; }
        }

        public void Print() => Console.WriteLine($"Name: {name}  Age: {age}");
        
    }
    class Person2
    {
        //Автоствойства
        public string Name { get; set; }
        public int Age { get; set; }

        public Person2(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Person2()
        {
        }
    }
   
    public class Person4
    {
        public string Name { get; init; } = "Undefined";
    }
}
