using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp72
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new B();

        }

        public class A
        {
            public A()
            {
                Console.WriteLine("A C'tor");
                PrintMe();
            }
            public virtual void PrintMe()
            {
                Console.WriteLine("A print me");
            }
        }
        public class B : A
        {
            public B()
            {
                Console.WriteLine("B C'tor");
                PrintMe();
            }
            public override void PrintMe()
            {
                Console.WriteLine("B Print Me");
            }
        }
    }
}
