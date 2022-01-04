using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            void SayHello()
            {
                Console.WriteLine("Hello");
            }
            SayHello();


            void SayHelloRu()
            {
                Console.WriteLine("Привет");
            }
            void SayHelloEn()
            {
                Console.WriteLine("Hello");
            }
            void SayHelloFr()
            {
                Console.WriteLine("Salut");
            }


            string language = "fr";

            switch (language)
            {
                case "en":
                    SayHelloEn();
                    break;
                case "ru":
                    SayHelloRu();
                    break;
                case "fr":
                    SayHelloFr();
                    break;
            }
            void SayHello1() => Console.WriteLine("Hello");

            void PrintMessage(string message)
            {
                Console.WriteLine(message);
            }

            PrintMessage("Hello work");           // Hello work
            PrintMessage("Hello METANIT.COM");    // Hello METANIT.COM
            PrintMessage("Hello C#");             // Hello C#

            void Sum(int x, int y)
            {
                int result = x + y;
                Console.WriteLine($"{x} + {y} = {result}");
            }

            Sum(10, 15);    // 10 + 15 = 25

            void Sum1(int x, int y) => Console.WriteLine($"{x} + {y} = { x + y }");

            int a = 10, b = 15, c = 6;
            Sum1(a, b);                  // 10 + 15 = 25
            Sum1(3, c);                  // 3 + 6 = 9
            Sum1(14, 4 + c);             // 14 + 10 = 24

            void PrintPerson(string name, int age)
            {
                Console.WriteLine($"Name: {name}  Age: {age}");
            }

            PrintPerson("Tom", 24); // Name: Tom  Age: 24

            void PrintPerson1(string name, int age = 1, string company = "Undefined")
            {
                Console.WriteLine($"Name: {name}  Age: {age}  Company: {company}");
            }

            PrintPerson1("Tom", 37, "Microsoft");  // Name: Tom  Age: 37  Company: Microsoft
            PrintPerson1("Tom", 37);               // Name: Tom  Age: 37  Company: Undefined
            PrintPerson1("Tom");

            void PrintPerson2(string name, int age = 1, string company = "Undefined")
            {
                Console.WriteLine($"Name: {name}  Age: {age}  Company: {company}");
            }

            PrintPerson2("Tom", company: "Microsoft", age: 37);  // Name: Tom  Age: 37  Company: Microsoft
            PrintPerson2(age: 41, name: "Bob");          // Name: Bob  Age: 41  Company: Undefined
            PrintPerson2(company: "Google", name: "Sam"); // Name: Sam  Age: 1   Company: Google
        }
    }
}
