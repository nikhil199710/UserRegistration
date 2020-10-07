using System;
using System.Collections.Concurrent;
using System.Text.RegularExpressions;

namespace Regex_UC
{
    class Pattern
    {
        public static string REGEX_ENTRY = "^[A-Z][a-zA-Z]{2,}$";
        public bool validateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, REGEX_ENTRY);
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Pattern pattern = new Pattern();
            Console.WriteLine("Enter First Name:");
            if (pattern.validateFirstName(Console.ReadLine()))
            {
                Console.WriteLine("First Name is Valid");
            }
            else
                Console.WriteLine("First Name is Invalid");
        }
    }
}
