using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCsharpandFunctional
{
    public class VowelConsonant
    {
        public static void VowelOrConsonant()
        {
            char ch;
            Console.WriteLine("Enter any Alphabet to check Vowel or Consonant");
            ch = Convert.ToChar(Console.ReadLine().ToLower());

            bool a = char.IsDigit(ch);

            if (a)
                Console.WriteLine("Entered Number");
            else 
            {
                switch (ch)
                {
                    case 'a':
                        Console.WriteLine("It is Vowel");
                        break;
                    case 'e':
                        Console.WriteLine("It is Vowel");
                        break;
                    case 'i':
                        Console.WriteLine("It is Vowel");
                        break;
                    case 'o':
                        Console.WriteLine("It is Vowel");
                        break;
                    case 'u':
                        Console.WriteLine("It is Vowel");
                        break;
                    default:
                        Console.WriteLine("It is Consonant");
                        break;
                }
            }


            
        }
    }
}
