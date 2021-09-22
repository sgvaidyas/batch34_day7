using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batch34_Day7
{
    class Student
    {
        protected string sname;
        protected int roll;

        public void getstudentdetails()
        {
            Console.WriteLine("Enter Roll and name");
            roll = Convert.ToInt32(Console.ReadLine());
            sname = Console.ReadLine();
        }
        public void display()
        {
            Console.WriteLine("ROLL            = "+roll);
            Console.WriteLine("NAME            = " + sname);
        }
    }


    class CourseDetails :Student
    {
        protected string coursename;
        protected int[] marks = new int[3];

        public void getmarks()
        {
            Console.WriteLine("Enter course name");
            coursename = Console.ReadLine();
            Console.WriteLine("Enter marks");
            for (int i = 0; i < marks.Length; i++)
                marks[i] = Convert.ToInt32(Console.ReadLine());
        }
        public void display()
        {
            base.display();
            Console.WriteLine("COURSE NAME     = " + coursename);
            for(int i=0;i<marks.Length;i++)
                Console.WriteLine("MARKS [" + i+"]    = " + marks[i]);
        }
    }
    class Report:CourseDetails
    {
        int total, per;
        public Report()
        {
            total = 0;
            per = 0;
        }
        public void  cal()
        {
            for (int i = 0; i < marks.Length; total += marks[i],i++) ;
            per = total / marks.Length;
        }
        public void display()
        {
            base.display();
            Console.WriteLine("TOTAL                = " +total);
            Console.WriteLine("PERCENT              = " + per);

        }
    }

    class Multi_level
    {
        static void Main(string[] args)
        {
            Report ob = new Report();
            ob.getstudentdetails();
            ob.getmarks();
            ob.cal();
            ob.display();
        }
    }
}
