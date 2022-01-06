using System;

namespace Covarianceandcontravarianceofgeneralizedinterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IMessenger<Message> outlook = new EmailMessenger();
            Message message = outlook.WriteMessage("Hello World");
            Console.WriteLine(message.Text);    // Email: Hello World


            IMessenger<EmailMessage> emailClient = new EmailMessenger();
            IMessenger<Message> messenger = emailClient;
            Message emailMessage = messenger.WriteMessage("Hi!");
            Console.WriteLine(emailMessage.Text);    // Email: Hi!

            IMessenger1<EmailMessage> outlook1 = new SimpleMessenger();
            outlook1.SendMessage(new EmailMessage("Hi!"));

            IMessenger1<Message> telegram = new SimpleMessenger();
            IMessenger1<EmailMessage> emailClient1 = telegram;
            emailClient1.SendMessage(new EmailMessage("Hello"));

            IMessenger2<EmailMessage, Message> messenger1 = new SimpleMessenger1();
            Message message1 = messenger1.WriteMessage("Hello World");
            Console.WriteLine(message.Text);
            messenger1.SendMessage(new EmailMessage("Test"));

            IMessenger2<EmailMessage, EmailMessage> outlook2 = new SimpleMessenger1();
            EmailMessage emailMessage1 = outlook2.WriteMessage("Message from Outlook");
            outlook2.SendMessage(emailMessage1);

            IMessenger2<Message, Message> telegram1 = new SimpleMessenger1();
            Message simpleMessage = telegram1.WriteMessage("Message from Telegram");
            telegram1.SendMessage(simpleMessage);
        }
    }
    class Message
    {
        public string Text { get; set; }
        public Message(string text) => Text = text;
    }
    class EmailMessage : Message
    {
        public EmailMessage(string text) : base(text) { }
    }
    interface IMessenger <out T>
    {
        T WriteMessage(string text);
    }
    class EmailMessenger : IMessenger<EmailMessage>
    {
        public EmailMessage WriteMessage(string text)
        {
            return new EmailMessage($"Email: {text}");
        }
    }
    interface IMessenger1<in T>
    {
        void SendMessage(T message);
    }
    class SimpleMessenger : IMessenger1<Message>
    {
        public void SendMessage(Message message)
        {
            Console.WriteLine($"Отправляется сообщение: {message.Text}");
        }
    }
}
