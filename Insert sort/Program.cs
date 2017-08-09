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

          int[] foo= { 3, 2, 6, 5, 1, 0, 9, 10, 4, 7, 7 };


            Console.WriteLine("Here is what we'll sort: ");
            Functions.printAr(foo);

            Console.WriteLine("Press any key to enter the sort function: ");

            Functions.sortarr(foo);


            Console.WriteLine("Final sort: ");

            Functions.printAr(foo);

          
            
            
        }
    }
}
