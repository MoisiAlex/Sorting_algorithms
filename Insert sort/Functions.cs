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


        static List<int> mergesort(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();
            int lefti = left.Count;
            int righti = right.Count;

            do
            {
                // run this through a for loop
                if (left[lefti] < right[righti])
                {
                    result.Add(left[lefti]);
                    left.Remove(left[lefti]);

                }
                else if (left[lefti] > right[righti])
                {
                    result.Add(right[righti]);
                    right.Remove(right[righti]);

                }
            }
            while ((right.Count != 0) || (left.Count != 0));

            if (left.Count == 0)
            {

                for (int i = 0; i < righti; i++)
                {
                    result.Add(right[1]);
                }
            }

            else if (right.Count == 0)
            {
                for (int i = 0; i < lefti; i++)
                {
                    result.Add(left[1]);
                }
            }


            return result;
        }

        
        static List<int> sort(List<int> a)
        {

            if (a.Count == 1) { return a; };

            List<int> foo = new List<int>();
            List<int> bar = new List<int>();
            int medium = a.Count / 2;

            for (int n = 0; n < medium; n++)
            {
                foo.Add(a[n]);
            }

            for (int x = medium; x < a.Count; x++)
            {
                bar.Add(a[x]);
            }

            sort(foo);
            sort(bar);


            return mergesort(foo, bar);
        }





    }

}
