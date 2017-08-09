using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insert_sort
{
    class Functions
    {

        public static void printAr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                if (i != arr.Length - 1)
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine(" ");
            Console.ReadKey();
        }




        public static int[] sortarr(int[] foo)
        {
            for (int i = 1; i < foo.Length; i++)
            {

                int key = foo[i];
                for (int x = i - 1; x >= 0; x--)
                {
                    if (foo[x] > key)
                    {
                        foo[x + 1] = foo[x];
                        foo[x] = key;
                    }

                }
                printAr(foo);
            }
            return foo;
        }
    }
}
