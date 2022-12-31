using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayEvenOddSepration
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 6,2,5 ,7,8,1,9,12 };
            int temp;
            int i = 0;
            int j = array.Length - 1;

            for (i = 0; i < j; )
            {

                if (array[i] % 2 == 0)
                {
                    if (array[j] % 2 == 1)
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                        //Swap 
                        i++; j--;
                        continue;
                    }
                    //else
                    j--;
                    continue;

                }

                if (array[i] % 2 == 1)
                {
                    i++;
                    continue;
                    
                }
                //else
                if (array[j] % 2 == 0)
                {
                    i++;
                    continue;
                }

                //else 
                i++;
                j--;
            }
           /* for (int i = 0; i < arr.Length; i++)
            {
               // Console.WriteLine("{0}     {1}", arr[i] % 2, arr[arr.Length - 1] % 2);
                if (arr[i] % 2 != 0)
                { 
                }

                else if (arr[i] % 2 == 0)
                {
                    even = arr[i];
                }

                if (arr[arr.Length -i] % 2 != 0)
                {
                    odd = arr[arr.Length - i];
                }
            }
            */
            for (int z = 0; z < array.Length; z++)
            {
                Console.WriteLine(array[z]);
            }
        }
    }
}
