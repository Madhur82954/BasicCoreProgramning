using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProgramning
{
    internal class SwapTwoNumbers
    {
        public void CheckSwapTwoNumbers()
        {
            Console.WriteLine("-------------- Swap Two Numbers -------------------");
            Console.WriteLine("Enter num1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("num1 : " + num1);
            Console.WriteLine("num2 : " + num2);
        }
    }
}
