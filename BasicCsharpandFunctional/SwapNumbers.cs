using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCsharpandFunctional
{
    public class SwapNumbers
    {
        public static void Swap()
        {
            int temp=0;
            int a = 0, b = 0;
            Console.WriteLine("Enter Two Numbers: ");
            Console.Write("a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before Swapping a= {0} b= {1}",a,b);
            temp = a;
            a=b;
            b=temp;

            Console.WriteLine("After Swapping a= {0} b= {1}", a, b);
        }
    }
}
