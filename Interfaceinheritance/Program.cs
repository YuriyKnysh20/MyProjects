using System;

namespace Interfaceinheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            IAction action1 = new RunAction();
            action1.Move(); // I am tired

            IRunAction action2 = new RunAction();
            action2.Move(); // I am tired
        }
    }
 
    interface IAction
    {
        void Move() => Console.WriteLine("I am moving");
    }
    interface IRunAction : IAction
    {
        new void Move() => Console.WriteLine("I am running");
    }
    class RunAction : IRunAction
    {
        public void Move() => Console.WriteLine("I am tired");
    }
}
