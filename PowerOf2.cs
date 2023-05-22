using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProgramning
{
    internal class PowerOf2
    {
        public void CalculatePowerOf2()
        {
            Console.WriteLine("---- Power of 2 ----");
            Console.WriteLine("Enter Num : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            int ans = 1;
            while (i <= n)
            {
                ans *= 2;
                i += 1;
            }
            Console.WriteLine("ans is = " + ans);
        }
    }
}
