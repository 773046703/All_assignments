using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace الواجب_العاشر_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string to check if it is a palindrome:");
            string inputString = Console.ReadLine();

            // Reverse the string
            char[] charArray = inputString.ToCharArray();
            Array.Reverse(charArray);
            string reversedString = new string(charArray);

            // Check if the reversed string is equal to the original string
            if (inputString == reversedString)
            {
                Console.WriteLine("The string is a palindrome.");
            }
            else
            {
                Console.WriteLine("The string is not a palindrome.");
            }
        }
    }
}
    

