using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace arrayNumCount
{
    class Program
    {
        const int SIZE = 12;
        static void Main(string[] args)
        {

            int[] numbers = new int[SIZE] { 5, 5, 5, 7, 7, 7, 9, 7, 9, 9, 9, 1 };
            int n = count(numbers, 5);
            Console.WriteLine(n);
        }

        public static int count(int[] sampled, int val)
        {

        int count = 0;
           for (int i = 0; i < sampled.Length; i++) {
            if (sampled[i] == val) {
             count++;
           }
        }
          return count;
      }
    }
}
