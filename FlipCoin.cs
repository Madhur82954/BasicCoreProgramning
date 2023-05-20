using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProgramning
{
    internal class FlipCoin
    {
        public void checkHeadTail()
        {
            int TailCount = 0, HeadCount = 0,Headpercentage,Tailpercentage;
            Console.WriteLine("----Flip Coin and Check Percentage");
            Console.WriteLine("Enter number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int checkheadtail = random.Next(0, 1);
            if (checkheadtail < 0.5)
            {
                TailCount++;
            }
            else
            {
                HeadCount++;
            }
            Headpercentage = (HeadCount / num) * 100;
            Console.WriteLine("Head Percentage is = "+Headpercentage);
            Tailpercentage = (TailCount / num) * 100;
            Console.WriteLine("Tail Percentage is = " + Tailpercentage);
        }
    }
}
