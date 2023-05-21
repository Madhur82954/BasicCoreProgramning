using System;

namespace BasicCoreProgramning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter option \n1) Flip Coin\n2) Leap Year");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FlipCoin flip = new FlipCoin();
                    flip.checkHeadTail();
                    break;

                case 2:
                    LeapYear leap = new LeapYear();
                    leap.checkleapyear();
                    break;
            }
        }
    }
}
