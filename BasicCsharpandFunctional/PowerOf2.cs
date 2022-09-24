using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCsharpandFunctional
{
    public class PowerOf2
    {
        public static void Power()
        {
            int n = 0;
            Console.WriteLine("Enter Power value N");
            n=Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(2*i);
            }
        }
    }
}
