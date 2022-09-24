using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCsharpandFunctional
{
    public class HarmonicNumber
    {
        public static void Harmonic()
        {
            int N = 0;
            Console.WriteLine("Enter N-th Harmonic Number");
            N=Convert.ToInt32(Console.ReadLine());
            double harmonic = 1;

            for (int i = 2; i <= N; i++)
            {
                harmonic += (double)1 / i;//Applying Formula to get Harmonic
            }
            Console.WriteLine(harmonic);
        }
    }
}
