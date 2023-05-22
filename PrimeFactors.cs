using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProgramning
{
    internal class PrimeFactors
    {
        public void CheckPrimeFactors()
        {
            Console.WriteLine("----------- Prime Factors ------------");
            Console.WriteLine("Enter Number : ");
            int N = Convert.ToInt32(Console.ReadLine());
            for(int i = 2; i * i <= N; i++)
            {
                if (N % i == 0)
                {
                    Console.WriteLine(N + "is a factor of " + i);
                }
            }
        }
    }
}
