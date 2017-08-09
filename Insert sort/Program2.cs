using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insert_sort
{
        class Program
    {



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
            while ((right.Count !=0) || (left.Count!=0));

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
            int medium = a.Count/2;

            for (int n = 0; n <medium; n++)
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


       

        static void Main(string[] args)
        {
            //n Declar array, for each element in array compare to previous element, if smaller move array to left, insert element otherwise end loop

          List<int> foo = new List<int>()
          { 3, 2, 6, 1 };

            sort(foo); 

/*
            Console.WriteLine("Here is what we'll sort: ");
            Functions.printAr(foo);

            Console.WriteLine("Press any key to enter the sort function: ");

            Functions.sortarr(foo);


            Console.WriteLine("Final sort: ");

            Functions.printAr(foo);

        */  
            
            
        }
    }
}
