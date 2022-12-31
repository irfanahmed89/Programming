using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayIntersection
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = {2,3,4,5,7,8,9,10,15,19 };
            int[] b = {19, 4, 5, 6 ,12,10};

                for(int i=0; i<a.Length; i++)
                {
                    for(int j=0; j<b.Length; j++)
                    {
                        if (a[i] == b[j])
                            Console.WriteLine(a[i]);
                    }
                }
        }
    }
}
