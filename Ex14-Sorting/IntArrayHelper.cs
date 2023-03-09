using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ex14_Sorting
{
    public class IntArrayHelper
    {
        public static int[] Sort(int[] array)
        {
            int temp = 0;  
            for (int i=0; i <= array.Length-1; i++)
            {
                for(int j=i+1; j<array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            return array;
        }

        public static int[] Reverse(int[] array)
        {
            int temp = 0;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            return array;
        }

        public static void Print(int[] array)
        {
            Console.Write("Array: ");
            foreach (var item in array)
            {
                Console.Write(item+" ");
            }
            Console.Write("\n");
        }
    }
}
