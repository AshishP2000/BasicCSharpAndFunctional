using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCsharpandFunctional
{
    public class EvenOdd
    {
        public static void EvenOrOdd()
        {
            int a = 0;
            Console.WriteLine("Enter Number to check Even or Odd");
            a=Convert.ToInt32(Console.ReadLine());


            if (a % 2 == 0)
                Console.WriteLine("{0} is Even",a);
            else
                Console.WriteLine("{0} is Odd",a);
        }
    }
}
