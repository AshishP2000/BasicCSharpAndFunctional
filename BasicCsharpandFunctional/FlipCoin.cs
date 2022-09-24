using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCsharpandFunctional
{
    public class FlipCoin
    {
        public static void Flip()
        {
            Random random = new Random();
            

            int n = 0,count1=0,count2=0;
            double perH=0,perT=0;
            Console.WriteLine("Enter how many times Coin will Flip");
            n=Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int r = random.Next(0, 2);
                if (r < 0.5)
                {
                    count1++;
                }
                else
                {
                    count2++;
                }
            }
            perH = (count1 *100)/n;
            perT = (count2 * 100)/n;
            Console.WriteLine("Percentage of Heads: {0}%  and Percentage of Tails: {1}%",perH,perT);

        }
    }
}
