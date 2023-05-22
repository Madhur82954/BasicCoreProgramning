﻿using System;

namespace BasicCoreProgramning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter option \n1) Flip Coin\n2) Leap Year\n3)Power of 2\n4)Harmonic Number\n5)Prime Factors\n6) Quotient Remainder");
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

                case 3:
                    PowerOf2 power = new PowerOf2();
                    power.CalculatePowerOf2();
                    break;

                case 4:
                    HarmonicNumber harmonic = new HarmonicNumber();
                    harmonic.CalculateHarmonicNumber();
                    break;

                case 5:
                    PrimeFactors prime = new PrimeFactors();
                    prime.CheckPrimeFactors();
                    break;
                
                case 6:
                    QuotientRemainder quotient = new QuotientRemainder();
                    quotient.ComputeQuotientRemainder();
                    break;
            }
        }
    }
}
