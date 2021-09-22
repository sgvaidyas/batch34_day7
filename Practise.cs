using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batch34_Day7
{
    class Practise
    {
        static void Main(string[] args)
        {
            int n = 7;
            int[] a = new int[n*n];
            int ind = n * n - n;
            a[ind] = 1;
            for(int i=0;i<n*n;i++)
            {
                if(i%n==0)
                    Console.WriteLine();
                Console.Write(a[i]+"\t");
            }
        }
    }
}
