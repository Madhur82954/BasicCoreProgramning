using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProgramning
{
    internal class LeapYear
    {
        public void checkleapyear()
        {
            Console.WriteLine("Enter Year");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year%4==0)
            {
                Console.WriteLine("it is a Leap year");
            }
            else
            {
                Console.WriteLine("it is not a leap year");
            }
        }
    }
}
