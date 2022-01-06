using System;

namespace Interfacesingeneralizations
{
    class Program
    {
        static void Main(string[] args)
        {
            // создаем мессенджер
            var telegram = new Messenger<Message>();
            // создаем сообщение
            var message = new Message("How are you doing?");
            // отправляем сообщение
            telegram.Send(message);

            IUser<int> user1 = new User<int>(6789);
            Console.WriteLine(user1.Id);    // 6789

            IUser<string> user2 = new User<string>("12345");
            Console.WriteLine(user2.Id);    // 12345

            IUser<int> user3 = new IntUser(12345);
            Console.WriteLine(user3.Id);

            IntUser user4 = new IntUser(9840);
            Console.WriteLine(user4.Id);

        }
    }
    class Messenger<T> where T : IMessage, IPrintable
    {
        public void Send(T message)
        {
            Console.WriteLine("Отправка сообщения:");
            message.Print();
        }
    }
    class IntUser:IUser<int>
    {
        public int Id { get; set; }
        public IntUser(int id) => Id = id;
    }
    interface IMessage
    {
        string Text { get; } // текст сообщения
    }
    interface IPrintable
    {
        void Print();
    }
    class Message : IMessage, IPrintable
    {
        public string Text { get; }
        public Message(string text) => Text = text;

        public void Print() => Console.WriteLine(Text);
    }
    //Обобщённые интерфейсы

    interface IUser<T>
    {
        T Id { get; }
    }
    class User<T> : IUser<T>
    {
        public T Id { get; }
        public User(T id) => Id = id;
    }
}
