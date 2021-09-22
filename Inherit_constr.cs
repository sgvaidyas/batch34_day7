using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batch34_Day7
{
    class A
    {
        public A()
        {
            Console.WriteLine("hi this is AAAAAAA");
        }
    }
    class B:A
    {
        public B()
        {
            Console.WriteLine("hi this is BBBBBBB");
        }
    }
    class C:B
    {
        public C()
        {
            Console.WriteLine("hi this is CCCCCCCCCCC");
        }
    }

    class Inherit_constr
    {
        static void Main(string[] args)
        {
            C ob = new C();
        }
    }
}
