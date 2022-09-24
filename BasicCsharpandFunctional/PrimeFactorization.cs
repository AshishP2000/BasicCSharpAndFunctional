using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCsharpandFunctional
{
    public class PrimeFactorization
    {
        public static void PrimeFactor()
        {
            int n = 0;
            List<int> factors = new List<int>();//created list
            Console.WriteLine("Enter number to find prime Factors");
            n=Convert.ToInt32(Console.ReadLine());//entered number to find prime facors
            Console.WriteLine("Prime Factors");

            for (int j = 1; j < n; j++)
            {
                if(n%j==0)
                    factors.Add(j);//added factors to an list
            }

            for (int k = 0; k < factors.Count; k++)
            {
                int count = 0;
                for (int i = 1; i <= factors[k]; i++)
                {
                    if (factors[k] % i == 0)//finding prime factors
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    Console.WriteLine(factors[k]);//printing prime facotrs
                }
                
            }
            




        }
    }
}
