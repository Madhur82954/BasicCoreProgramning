using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProgramning
{
    internal class EvenOdd
    {
        public void CheckEvenOdd()
        {
            Console.WriteLine("----------- Check Even Odd ------------------");
            Console.WriteLine("Enter Number : ");
            int N = Convert.ToInt32(Console.ReadLine());
            if (N % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }
        }
    }
}
