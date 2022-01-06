using System;

namespace Implementationofinterfacesinbaseandderivedclasses
{
    class Program
    {
        static void Main(string[] args)
        {
            IAction action = new HeroAction();
            action.Move();  // Move in BaseAction

            BaseAction1 action1 = new HeroAction1();
            action1.Move();            // Move in BaseAction

            IAction1 action2 = new HeroAction1();
            action2.Move();           // Move in BaseAction

            BaseAction2 action3 = new HeroAction2();
            action3.Move();            // Move in BaseAction

            IAction2 action4 = new HeroAction2();
            action4.Move();             // Move in IAction

            HeroAction2 action5 = new HeroAction2();
            action5.Move();             // Move in HeroAction
        }
    }
    interface IMovable
    {
        void Move();
    }
    abstract class Person : IMovable
    {
        public abstract void Move();
    }
    class Driver : Person
    {
        public override void Move() => Console.WriteLine("Шофер ведет машину");
    }

   
 
    interface IAction
    {
        void Move();
    }
    class BaseAction
    {
        public void Move() => Console.WriteLine("Move in BaseAction");
    }
    class HeroAction : BaseAction, IAction { }
    //Скрытие метода в производном классе
    interface IAction1
    {
        void Move();
    }
    class BaseAction1 : IAction1
    {
        public void Move() => Console.WriteLine("Move in BaseAction");

    }
    class HeroAction1 : BaseAction1
    {
        public new void Move() => Console.WriteLine("Move in HeroAction");
    }

    interface IAction2
    {
        void Move();
    }
    class BaseAction2 : IAction2
    {
        public void Move() => Console.WriteLine("Move in BaseAction");
    }
    class HeroAction2 : BaseAction2, IAction2
    {
        public new void Move() => Console.WriteLine("Move in HeroAction");
        // явная реализация интерфейса
        void IAction2.Move() => Console.WriteLine("Move in IAction");
    }
}
