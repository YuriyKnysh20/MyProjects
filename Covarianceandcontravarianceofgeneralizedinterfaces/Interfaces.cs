using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covarianceandcontravarianceofgeneralizedinterfaces
{
    interface IMessenger2<in T, out K>
    {
        void SendMessage(T message);
        K WriteMessage(string text);
    }
    class SimpleMessenger1 : IMessenger2<Message, EmailMessage>
    {
        public void SendMessage(Message message)
        {
            Console.WriteLine($"Отправляется сообщение: {message.Text}");
        }
        public EmailMessage WriteMessage(string text)
        {
            return new EmailMessage($"Email: {text}");
        }
    }
}
