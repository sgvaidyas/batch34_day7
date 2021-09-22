﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batch34_Day7
{

    class Square:Shape_single
    {
        float area, peri;
        public void calc()
        {
            area = len * len;
            peri = 4 * len;
        }
        public void display()
        {
            Console.WriteLine("LENGTH      = " + len);
            Console.WriteLine("AREA        = " + area);
            Console.WriteLine("PERIMETER   = " + peri);
        }
    }

    class Circle:Shape_single
    {
        float area, circumference, pi;
        public Circle()
        {
            pi = 3.142f;
        }
        public void calc()
        {
            area = pi * rad * rad;
            circumference = 2 * pi * rad;
        }
        public void display()
        {
            Console.WriteLine("RADIUS      = " + rad);
            Console.WriteLine("AREA        = " + area);
            Console.WriteLine("CIRCUMFERENCE   = " + circumference);
        }
    }


    class Implement_Hierarchy
    {
        static void Main(string[] args)
        {
            Square sq = new Square();
            sq.getlen();
            sq.calc();
            sq.display();

            Circle c = new Circle();
            c.getrad();
            c.calc();
            c.display();
        }
    }
}
