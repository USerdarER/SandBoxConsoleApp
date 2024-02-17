using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandBoxConsoleApp.Classes
{
    public static class Palindrome
    {
        public static bool IsPalindrome(int x)
        {
            char[] number = x.ToString().ToCharArray();
            char[] reverseNumber = new char[number.Length];
            if (number.Length > 0)
            {
                Array.Copy(number, reverseNumber, number.Length);
            }

            Array.Reverse(reverseNumber);

            var a = new string(number);
            var b = new string(reverseNumber);

            return a == b;
        }
    }
}
