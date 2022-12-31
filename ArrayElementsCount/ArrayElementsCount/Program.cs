using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayElementsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] A = { 1,1,1,2,2,3,4,4,4,4,5,6,6};
            //Array.Sort(A);
            //int count=1;
            //int x = A[0];
            //for (int i = 1; i < A.Length; i++)
            //{
            //    if (A[i] == x)
            //        count++;
            //    else
            //    {
            //        Console.WriteLine("count of {0} = {1}", A[i - 1], count);
            //        count = 1;
            //        x = A[i];
            //    }

                
            //}
            //Console.WriteLine("count of {0} = {1}", x, count);


            int[] arr = { 3, 4, 5, 3, 6, 9, 1, 6, 8, 7, 5, 3, 1, 4 };

            //int c = 0;
            //int y = arr[0];

            //for (int j = 0; j < arr.Length; j++)
            //{
            //    for (int k = 0; k < arr.Length; k++)
            //    {
            //        if (arr[k] == y)
            //           c++;
            //    }

            //    Console.WriteLine("cont number {0}   =   {1} ",y,c);
            //    y = arr[j];
            //    c = 0;
            //}

            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!dict.Keys.Contains(arr[i]))
                {
                    dict.Add(arr[i], 1);
                }
                else
                    dict[arr[i]] += 1;
            }

            foreach (var d in dict)
            {
                Console.WriteLine("element = {0} and count = {1}", d.Key, d.Value);
            }
        }


        


    }
}
