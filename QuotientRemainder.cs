using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProgramning
{
    internal class QuotientRemainder
    {
        public void ComputeQuotientRemainder()
        {
            Console.WriteLine("------------ Compute Quotient and Remainder ------------");
            int Quotient, Remainder;
            Console.WriteLine("Enter num1 : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num2 : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Quotient = num1 / num2;

            Remainder = num1 % num2;

            Console.WriteLine("Quotient is  = "+Quotient);
            Console.WriteLine("Remainder is  = " +Remainder);
        }
    }
}
