using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Insert_sort
{
        class Program
    {
               

        static void Main(string[] args)
        {
            //n Declar array, for each element in array compare to previous element, if smaller move array to left, insert element otherwise end loop

          List<int> foo = new List<int>()
          { 3, 2, 6, 1, 9, 0, 1, 12 };

            int[] bar = foo.ToArray();

            Console.WriteLine("Here is what we'll sort: ");
            Functions.printls(foo);

            Console.WriteLine("First Merge Sort: ");
            
            Functions.printls(Functions.sort(foo));


            Console.WriteLine("Press any key to enter the insert sort function: ");

            Functions.sortarr(bar);

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
