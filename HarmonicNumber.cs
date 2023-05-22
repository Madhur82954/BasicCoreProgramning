using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProgramning
{
    internal class HarmonicNumber
    {
        public void CalculateHarmonicNumber()
        {
            double sum = 0.0;

            Console.WriteLine("----- Harmonic Number-----");
            Console.WriteLine("Enter Number :");
            int num=Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= num; i++)
            {
                sum += 1 / (float)i;
            }
            Console.WriteLine("Sum of Harmonic Number is  = " + sum);
        }
    }
}
