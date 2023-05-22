using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProgramning
{
    internal class VowelConsonent
    {
        public void checkVowelConsonent()
        {
            Console.WriteLine("--------------- Vowel or Consonent --------------------");
            Console.WriteLine("Enter character : ");
            char ch = Convert.ToChar(Console.ReadLine());
            if ((ch == 'a') && (ch == 'e') && (ch == 'i') && (ch == 'o') && (ch == 'u'))
            {
                Console.WriteLine("it is Vowel");
            }
            else
            {
                Console.WriteLine("it is Consonent");
            }
        }
    }
}
