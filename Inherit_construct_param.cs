using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batch34_Day7
{

    class X
    {
        public X(int x)
        {
            Console.WriteLine("X = "+x);
        }
    }
    class Y:X
    {
        public Y(int x,int y):base(x)
        {

            Console.WriteLine("Y = " + y);
        }
    }
    class Z:Y
    {
        public Z(int x,int y,int z):base(x,y)
        {
            Console.WriteLine("Z = "+z);
        }
    }

    class Inherit_construct_param
    {
        static void Main(string[] args)
        {
            Z ob = new Z(33,44,55);
        }
    }
}


/* 
 * 
 
     class X
    {
        public X(int x)
        {
            Console.WriteLine("X = "+x);
        }
    }
    class Y:X
    {
        public Y(int x):base(x)
        {

            Console.WriteLine("Y class " );
        }
    }
    class Z:Y
    {
        public Z(int x,int z):base(x)
        {
            Console.WriteLine("Z = "+z);
        }
    }

    class Inherit_construct_param
    {
        static void Main(string[] args)
        {
            Z ob = new Z(33,44);
        }
    }    
     
     
     
     
     
     
     
     
     
     */
