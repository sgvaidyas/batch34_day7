using System;

namespace batch34_Day7
{
    abstract class MyAbstract
    {
        protected string roll, name;

        public void getdata()
        {
            Console.WriteLine("Enter roll & name");
            roll = Console.ReadLine();
            name = Console.ReadLine();
        }
        abstract public void display();
    }
    class MyChild:MyAbstract
    {
        string per;

        public void getper()
        {
            Console.WriteLine("Enter per");
            per = Console.ReadLine();
        }
        public override void display()
        {
            Console.WriteLine("ROLL    = " + roll);
            Console.WriteLine("NAME    = " + name);
            Console.WriteLine("PER     = " + per);

        }
    }
    class Abstract1Ex
    {
        static void Main(string[] args)
        {
            MyChild ob = new MyChild();
            ob.getdata();
            ob.getper();//from child class
            ob.display();


            MyAbstract ob1 = new MyChild();
            ob1.getdata();
            ob1.display();
        }
    }
}
