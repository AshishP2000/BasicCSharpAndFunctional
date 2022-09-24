using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCsharpandFunctional
{
    public class QuotientReminder
    {
        public static void QuotientAndReminder()
        {
            int Divident = 0, Divisor = 0, Quotient = 0, Reminder = 0;
            Console.WriteLine("Enter Divident and Divisor");
            Console.Write("Divident: ");
            Divident = Convert.ToInt32(Console.ReadLine());
            Console.Write("Divisor: ");
            Divisor = Convert.ToInt32(Console.ReadLine());

            Quotient = Divident / Divisor;
            Reminder = Divident % Divisor;

            Console.WriteLine("Quotoent: {0}",Quotient);
            Console.WriteLine("Reminder: {0}",Reminder);
        }
    }
}
