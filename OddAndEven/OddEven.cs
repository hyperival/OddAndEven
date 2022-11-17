using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddAndEven
{
    class OddEven
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter any number");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("your number is: " + num);

            if (num%2 == 0)
            {
                Console.WriteLine("number is even");

            }
            else
            {
                Console.WriteLine("number is odd");
            }

        }
    }
}
