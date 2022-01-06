using System;

namespace Applicationofinterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Car car = new Car();
            DoAction(person);
            DoAction(car);

            void DoAction(IMovable movable) => movable.Move();
            //Реализация интерфейса по умолчанию

            IMovable1 tom = new Person1();
            Car1 tesla = new Car1();
            tom.Move();     // Walking
            tesla.Move();   // Driving

            Message hello = new Message("Hello World");
            hello.Print();  // Hello World

            // Все объекты Message являются объектами IMessage
            IMessage hello1 = new Message("Hello METANIT.COM");
            Console.WriteLine(hello.Text); // Hello METANIT.COM

            // Не все объекты IMessage являются объектами Message, необходимо явное приведение
            // Message someMessage = hello; // ! Ошибка

            // Интерфейс IMessage не имеет свойства Print, необходимо явное приведение
            // hello.Print();  // ! Ошибка

            // если hello представляет класс Message, выполняем преобразование
            if (hello is Message someMessage) someMessage.Print();

            BaseAction baseAction1 = new BaseAction();

            // baseAction1.Move();  // ! Ошибка - в BaseAction нет метода Move
            // необходимо приведение к типу IAction
            // небезопасное приведение
            ((IAction)baseAction1).Move();
            // безопасное приведение 
            if (baseAction1 is IAction action) action.Move();
            // или так
            IAction baseAction2 = new BaseAction();
            baseAction2.Move();
            Person2 person1 =new Person2();
            ((ISchool)person1).Study();
            ((IUniversity)person1).Study();

            IMovable2 tom1 = new Person3("Tom");
            // подписываемся на событие
            tom1.MoveEvent += () => Console.WriteLine($"{tom1.Name} is moving");
            tom1.Move();

        }
    }

    interface IMovable
    {
        void Move();
    }
    class Person : IMovable
    {
        public void Move() => Console.WriteLine("Человек идет");
    }
    struct Car : IMovable
    {
        public void Move() => Console.WriteLine("Машина едет");
    }

 
    interface IMovable1
    {
        void Move() => Console.WriteLine("Walking");
    }
    class Person1 : IMovable1 { }
    class Car1 : IMovable
    {
        public void Move() => Console.WriteLine("Driving");
    }

    interface IMessage
    {
        string Text { get; set; }
    }
    interface IPrintable
    {
        void Print();
    }
    class Message : IMessage, IPrintable
    {
        public string Text { get; set; }
        public Message(string text) => Text = text;
        public void Print() => Console.WriteLine(Text);
    }
    //Явная реализация интерфейса

    interface IAction
    {
        void Move();
    }
    class BaseAction : IAction
    {
        void IAction.Move() => Console.WriteLine("Move in Base Class");
    }
    //Применение интерфейса явным образоим

    class Person2 : ISchool, IUniversity
    {
        void ISchool.Study() => Console.WriteLine("Учеба в школе");
        void IUniversity.Study() => Console.WriteLine("Учеба в университете");
    }
    interface ISchool
    {
        void Study();
    }
    interface IUniversity
    {
        void Study();
    }


 
 
    interface IMovable2
    {
        protected internal void Move();
        protected internal string Name { get; }
        delegate void MoveHandler();
        protected internal event MoveHandler MoveEvent;
    }
    class Person3 : IMovable2
    {
        string name;
        // явная реализация события - дополнительно создается переменная
        IMovable2.MoveHandler? moveEvent;
        event IMovable2.MoveHandler IMovable2.MoveEvent
        {
            add => moveEvent += value;
            remove => moveEvent -= value;
        }
        // явная реализация свойства - в виде автосвойства
        string IMovable2.Name { get => name; }
        public Person3(string name) => this.name = name;
        // явная реализация метода
        void IMovable2.Move()
        {
            Console.WriteLine($"{name} is walking");
            moveEvent?.Invoke();
        }
    }
}
