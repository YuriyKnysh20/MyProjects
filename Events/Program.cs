using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(100);
            account.Notify += DisplayMessage;   // Добавляем обработчик для события Notify
            account.Put(20);    // добавляем на счет 20
            Console.WriteLine($"Сумма на счете: {account.Sum}");
            account.Take(70);   // пытаемся снять со счета 70
            Console.WriteLine($"Сумма на счете: {account.Sum}");
            account.Take(180);  // пытаемся снять со счета 180
            Console.WriteLine($"Сумма на счете: {account.Sum}");

            void DisplayMessage(string message) => Console.WriteLine(message);

            Account1 acc = new Account1(100);
            acc.Notify += DisplayMessage1;       // добавляем обработчик DisplayMessage
            acc.Put(20);    // добавляем на счет 20
            acc.Notify -= DisplayMessage1;     // удаляем обработчик DisplayRedMessage
            acc.Put(20);    // добавляем на счет 20

            void DisplayMessage1(string message) => Console.WriteLine(message);
        }
    }
    class Account
    {
        public delegate void AccountHandler(string message);
        public event AccountHandler? Notify;              // 1.Определение события
        public Account(int sum) => Sum = sum;
        public int Sum { get; private set; }
        public void Put(int sum)
        {
            Sum += sum;
            Notify?.Invoke($"На счет поступило: {sum}");   // 2.Вызов события 
        }
        public void Take(int sum)
        {
            if (Sum >= sum)
            {
                Sum -= sum;
                Notify?.Invoke($"Со счета снято: {sum}");   // 2.Вызов события
            }
            else
            {
                Notify?.Invoke($"Недостаточно денег на счете. Текущий баланс: {Sum}"); ;
            }
        }
    }


    class Account1
    {
        public delegate void AccountHandler(string message);
        event AccountHandler? notify;
        public event AccountHandler Notify
        {
            add
            {
                notify += value;
                Console.WriteLine($"{value.Method.Name} добавлен");
            }
            remove
            {
                notify -= value;
                Console.WriteLine($"{value.Method.Name} удален");
            }
        }
        public Account1(int sum) => Sum = sum;
        public int Sum { get; private set; }
        public void Put(int sum)
        {
            Sum += sum;
            notify?.Invoke($"На счет поступило: {sum}");   // 2.Вызов события 
        }
        public void Take(int sum)
        {
            if (Sum >= sum)
            {
                Sum -= sum;
                notify?.Invoke($"Со счета снято: {sum}");   // 2.Вызов события
            }
            else
            {
                notify?.Invoke($"Недостаточно денег на счете. Текущий баланс: {Sum}"); ;
            }
        }
    }
}
