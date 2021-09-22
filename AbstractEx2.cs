using System;

namespace batch34_Day7
{
    abstract class One
    {
        protected int x;
        public void getdata()
        {
            Console.WriteLine("Enter x = ");
            x = int.Parse(Console.ReadLine());
        }
        abstract public void printme();
    }
    abstract class Two :One
    {
        protected int y;
        public void getYdata()
        {
            Console.WriteLine("Enter y= ");
            y = int.Parse(Console.ReadLine());
        }
    }
    class Three:Two
    {
        public override void printme()
        {
            Console.WriteLine("X = "+x + "\nY = "+y);
        }
    }
    class AbstractEx2
    {
        static void Main(string[] args)
        {
            Three ob = new Three();
            ob.getdata();
            ob.getYdata();
            ob.printme();
        }
    }
}
