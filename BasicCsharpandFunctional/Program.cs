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
            Console.WriteLine("1.Swap Numbers");
            choice = Convert.ToInt32(Console.ReadLine());
            
            switch (choice)
            {
                case 1:
                    //int a = 0, b = 0;
                    //a = Convert.ToInt32(Console.ReadLine());
                    //b = Convert.ToInt32(Console.ReadLine());
                    SwapNumbers.Swap();
                    break;
            }

            

            Console.ReadLine();
        }
    }
}
