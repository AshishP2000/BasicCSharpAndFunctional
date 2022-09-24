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
            Console.WriteLine("1.Swap Numbers\n2.Even or Odd\n3.Largest Among Three\n4.Qutient and Reminder\n5.Vowel or Consonant" +
                "\n6.Prime Facors");
            choice = Convert.ToInt32(Console.ReadLine());
            
            switch (choice)
            {
                case 1:
                    SwapNumbers.Swap();
                    break;
                case 2:
                    EvenOdd.EvenOrOdd();
                    break;
                case 3:
                    LargestAmongThree.Largest();
                    break;
                case 4:
                    QuotientReminder.QuotientAndReminder();
                    break;
                case 5:
                    VowelConsonant.VowelOrConsonant();
                    break;
                case 6:
                    PrimeFactorization.PrimeFactor();
                    break;
            }
            Console.ReadLine();
        }
    }
}
