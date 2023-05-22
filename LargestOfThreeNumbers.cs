using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProgramning
{
    internal class LargestOfThreeNumbers
    {
        public void checkThreeNumbers()
        {
            Console.WriteLine("------------ Largest Of Three Numbers --------------------");
            Console.WriteLine("Enter num1 : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num2 : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num3 : ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if(num1>num2 && num1>num3)
            {
                Console.WriteLine("Num1 is greater");
            }
            else if (num2>num1 && num2>num3)
            {
                Console.WriteLine("Num2 is greater");
            }
            else if(num3>num1 && num3>num2)
            {
                Console.WriteLine("Num3 is greater");
            }
        }
    }
}
