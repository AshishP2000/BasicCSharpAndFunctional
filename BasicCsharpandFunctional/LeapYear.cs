using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCsharpandFunctional
{
    public class LeapYear
    {
        public static void Leap()
        {
            string n;
            int Year = 0;
            Console.WriteLine("Enter Year");
            n = Console.ReadLine();
            if (n.Trim().Length == 4)
            {
                Year=Convert.ToInt32(n);
                if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
                    Console.WriteLine("{0} is a Leap Year.", Year);
                else
                    Console.WriteLine("{0} is not a Leap Year.", Year);
            }
            else
            {
                Console.WriteLine("Enter only 4 digit");
            }
        }
    }
}
