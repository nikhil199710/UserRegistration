using System;
using System.Text.RegularExpressions;

namespace Regex_UC
{
    class Pattern
    {
        public static string REGEX_FIRST_NAME = "^[A-Z][a-zA-Z]{2,}$";
        public bool validateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, REGEX_FIRST_NAME);
        }



        public static string REGEX_LAST_NAME = "^[A-Z][a-zA-Z]{2,}$";
        public bool validateLastName(string lastName)
        {
            return Regex.IsMatch(lastName, REGEX_LAST_NAME);
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



