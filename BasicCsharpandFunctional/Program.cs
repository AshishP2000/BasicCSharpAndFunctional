using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCsharpandFunctional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            Console.WriteLine("Enter number to choose operation: ");
            Console.WriteLine("1.Swap Numbers\n2.Even or Odd");
            choice = Convert.ToInt32(Console.ReadLine());
            
            switch (choice)
            {
                case 1:
                    SwapNumbers.Swap();
                    break;
                case 2:
                    EvenOdd.EvenOrOdd();
                    break;
            }

            

            Console.ReadLine();
        }
    }
}
