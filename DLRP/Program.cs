using System;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

namespace IronPythonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ScriptEngine engine = Python.CreateEngine();
            engine.Execute("print 'hello, world'");

            Console.WriteLine("Введите число:");
            int x = Int32.Parse(Console.ReadLine());

            ScriptEngine engine1 = Python.CreateEngine();
            ScriptScope scope = engine1.CreateScope();

            
          
            // вызываем функцию и получаем результат
           
         

            Console.Read();
        }
    }
}