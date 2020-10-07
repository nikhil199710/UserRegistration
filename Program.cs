using System;
using System.Text.RegularExpressions;

namespace Regex_UC
{
    class Pattern
    {
        public static string REGEX_ENTRY = "^[A-Z][a-zA-Z]{2,}$";
        public bool validateLastName(string lastName)
        {
            return Regex.IsMatch(lastName, REGEX_ENTRY);
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Pattern pattern = new Pattern();
            Console.WriteLine("Enter Last Name:");
            if (pattern.validateLastName(Console.ReadLine()))
            {
                Console.WriteLine("Last Name is Valid");
            }
            else
            {
                Console.WriteLine("Last Name is Invalid");
            }
        }
    }
}
