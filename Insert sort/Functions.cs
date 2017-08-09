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


        public static void printls(List<int> arr)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                Console.Write(arr[i]);
                if (i != arr.Count - 1)
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


        static List<int> merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();
            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() <= right.First())  //Comparing First two elements to see which is smaller
                    {
                        result.Add(left.First());
                        left.Remove(left.First());      //Rest of the list minus the first element
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());

                    right.Remove(right.First());
                }
            }
            return result;

         }

        
        public static List<int> sort(List<int> a)
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

            foo = sort(foo);
            bar = sort(bar);
            return merge(foo, bar);
        }





    }

}
