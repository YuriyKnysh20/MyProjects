using System;

namespace TypesofexceptionsExceptionclass
{
    class Program
    {
        static void Main(string[] args)
        {
            try
{
                int x = 5;
                int y = x / 0;
                Console.WriteLine($"Результат: {y}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");
                Console.WriteLine($"Метод: {ex.TargetSite}");
                Console.WriteLine($"Трассировка стека: {ex.StackTrace}");
            }

            try
            {
                int[] numbers = new int[4];
                numbers[7] = 9;     // IndexOutOfRangeException

                int x = 5;
                int y = x / 0;  // DivideByZeroException
                Console.WriteLine($"Результат: {y}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Возникло исключение DivideByZeroException");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                object obj = "you";
                int num = (int)obj;     // System.InvalidCastException
                Console.WriteLine($"Результат: {num}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Возникло исключение DivideByZeroException");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Возникло исключение IndexOutOfRangeException");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");
            }

            //Оператор throw

            try
            {
                try
                {
                    Console.Write("Введите имя: ");
                    string? name = Console.ReadLine();
                    if (name == null || name.Length < 2)
                    {
                        throw new Exception("Длина имени меньше 2 символов");
                    }
                    else
                    {
                        Console.WriteLine($"Ваше имя: {name}");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Ошибка: {e.Message}");
                    throw;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            try
            {
                Person person = new Person { Name = "Tom", Age = 17 };
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            try
            {
                Person person = new Person { Name = "Tom", Age = 17 };
            }
            catch (PersonException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                Console.WriteLine($"Некорректное значение: {ex.Value}");
            }
        }

    }

    class Person
    {
        private int age;
        public string Name { get; set; } = "";
        public int Age
        {
            get => age;
            set
            {
                if (value < 18)
                    throw new Exception("Лицам до 18 регистрация запрещена");
                else
                    age = value;
            }
        }
    }

    class PersonException : Exception
    {
       
        public int Value { get; }
        public PersonException(string message, int val)
            : base(message)
        {
            Value = val;
        }
    }

}
