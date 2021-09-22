using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batch34_Day7
{
    class PersonalInfo
    {
        public string ssid, name, age;

        public void getdata()
        {
            Console.WriteLine("SSID NAME & AGE");
            ssid = Console.ReadLine();
            name = Console.ReadLine();
            age = Console.ReadLine();
        }
        public void disp()
        {
            Console.WriteLine("SSID    = " + ssid);
            Console.WriteLine("NAME    = " + name);
            Console.WriteLine("AGE    = " + age);
        }
    }
    class Employee
    {
        PersonalInfo emp;
        string empid, desig;
        public Employee()
        {
            emp = new PersonalInfo();
        }
        public void getEmpInfo()
        {
            emp.getdata();
            Console.WriteLine("EMP ID & DESIG");
            empid = Console.ReadLine();
            desig = Console.ReadLine();
        }
        public void print()
        {
            emp.disp();
            Console.WriteLine("EMPID    = " + empid);
            Console.WriteLine("DESIG    = " + desig);
        }
    }


    class AggregateImp
    {
        static void Main(string[] args)
        {
            Employee ob = new Employee();
            ob.getEmpInfo();
            ob.print();
        }
    }
}
