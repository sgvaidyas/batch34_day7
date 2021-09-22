using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batch34_Day7
{
    class Shape_single
    {
        protected  float len, bred, rad;
        public void getlen()
        {
            Console.Write("\nEnter len = ");
            len = float.Parse(Console.ReadLine());
        }
        public void getbred()
        {
            Console.Write("\nEnter bred = ");
            bred = float.Parse(Console.ReadLine());
        }
        public void getrad()
        {
            Console.Write("\nEnter rad = ");
            rad = float.Parse(Console.ReadLine());
        }
    }
}
