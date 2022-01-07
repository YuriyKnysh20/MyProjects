using System;

namespace Patternmatching
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee tom = new Manager();
            UseEmployee(tom);   // Manager works
            void UseEmployee(Employee emp)
            {
                if (emp is Manager manager && manager.IsOnVacation == false)
                {
                    manager.Work();
                }
                else
                {
                    Console.WriteLine("Преобразование не допустимо");
                }
            }

            Employee? bob = new Employee();
            Employee? tom1 = null;

            UseEmployee(bob);
            UseEmployee(tom1);

            void UseEmployee1(Employee? emp)
            {
                if (emp is not null)
                    emp.Work();
            }


            //Использование Конструкции switch

            Employee bob1 = new Employee();
            Employee tom2 = new Manager();
            UseEmployee(tom2);   // Manager works
            UseEmployee(bob1);   // Object is not manager

            void UseEmployee2(Employee? emp)
            {
                switch (emp)
                {
                    case Manager manager:
                        manager.Work();
                        break;
                    case null:
                        Console.WriteLine("Object is null");
                        break;
                    default:
                        Console.WriteLine("Object is not manager");
                        break;
                }
            }

            string GetMessage(Person? p) => p switch
            {
                { Language: "english" } => "Hello!",
                { Language: "german", Status: "admin" } => "Hallo, admin!",
                { Language: "french" } => "Salut!",
                { } => "undefined",
                null => "null"       // если Person p = null
            };
            //Применение паттерна свойств

            Person pierre = new Person { Language = "french", Status = "user", Name = "Pierre" };
            string message = GetMessage(pierre);
            Console.WriteLine(message);     // Salut!

            Person tomas = new Person { Language = "german", Status = "admin", Name = "Tomas" };
            Console.WriteLine(GetMessage(tomas));     // Hallo, admin!

            Person pablo = new Person { Language = "spanish", Status = "user", Name = "Pablo" };
            Console.WriteLine(GetMessage(pablo));     // undefined

            Console.WriteLine(GetMessage(null));     // null
            //Паттерн кортежей

            string GetWelcome(string lang, string daytime) => (lang, daytime) switch
            {
                ("english", "morning") => "Good morning",
                ("english", "evening") => "Good evening",
                ("german", "morning") => "Guten Morgen",
                ("german", "evening") => "Guten Abend",
                _ => "Здрасьть"
            };

            string message1 = GetWelcome("english", "evening");
            Console.WriteLine(message);  // Good evening

            message = GetWelcome("french", "morning");
            Console.WriteLine(message);  // Здрасьть

            string GetWelcome1(MessageDetails details) => details switch
            {
                ("english", "morning", _) => "Good morning",
                ("english", "evening", _) => "Good evening",
                ("german", "morning", _) => "Guten Morgen",
                ("german", "evening", _) => "Guten Abend",
                (_, _, "admin") => "Hello, Admin",
                _ => "Здрасьть"
            };
            //Применим этот паттерн

            MessageDetails details1 = new MessageDetails { Language = "english", DateTime = "evening", Status = "user" };
            string message2 = GetWelcome1(details1);
            Console.WriteLine(message);  // Good evening

            MessageDetails details2 = new MessageDetails { Language = "french", DateTime = "morning", Status = "admin" };
            message2 = GetWelcome1(details2);
            Console.WriteLine(message2);  // Hello, Admin
            //Реляционный паттерн

            decimal Calculate(decimal sum)
            {
                return sum switch
                {
                    <= 0 => 0,              // если sum меньше или равно 0, возвращаем 0
                    < 50000 => sum * 0.05m, // если sum меньше 50000, возвращаем sum * 0.05m
                    < 100000 => sum * 0.1m, // если sum меньше 100000, возвращаем sum * 0.1m
                    _ => sum * 0.2m        // в остальных случаях возвращаем sum * 0.2m
                };
            }

            Console.WriteLine(Calculate(-200));     // 0
            Console.WriteLine(Calculate(0));        // 0 
            Console.WriteLine(Calculate(10000));    // 500
            Console.WriteLine(Calculate(60000));    // 6000
            Console.WriteLine(Calculate(200000));   // 4000
            //Логический паттерн

            string CheckAge(int age)
            {
                return age switch
                {
                    < 1 or > 110 => "Недействительный возраст",   // если age больше 110 и меньше 1
                    >= 1 and < 18 => "Доступ запрещен",           // если age равно или больше 1 и меньше 18
                    _ => "Доступ разрешен"                      // в остальных случаях
                };
            }
            Console.WriteLine(CheckAge(200));
            Console.WriteLine(CheckAge(17));    // Доступ запрещен
            Console.WriteLine(CheckAge(18));   // Доступ разрешен

            string CheckAge1(int age) => age switch
            {
                not 33 => "Обычный возраст",   // если age НЕ равен 33
                _ => "Вам 33 года"             // в остальных случаях, то есть если age = 33
            };
        }
    }
    //Позиционный паттерн
    class MessageDetails
   {
    public string Language { get; set; } = "";    // язык пользователя
    public string DateTime { get; set; } = "";    // время суток
    public string Status { get; set; } = "";     // статус пользователя

    public void Deconstruct(out string lang, out string datetime, out string status)
    {
        lang = Language;
        datetime = DateTime;
        status = Status;
    }
  }
    class Person
    {
        public string Name { get; set; } = "";        // имя пользователя
        public string Status { get; set; } = "";     // статус пользователя
        public string Language { get; set; } = "";   // язык пользователя
    }
    class Employee
    {
        public virtual void Work() => Console.WriteLine("Employee works");
        
    }

    class Manager : Employee
    {
        public override void Work() => Console.WriteLine("Manager works");
        public bool IsOnVacation { get; set; }
    }
   

   
}
