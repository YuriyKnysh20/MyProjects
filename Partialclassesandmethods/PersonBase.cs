using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partialclassesandmethods
{
    public partial class Person
    {
        public void Move()
        {
            Console.WriteLine("I am moving");
        }
        partial void Read();
        public void DoSomething()
        {
            Read();
        }
    }
}
