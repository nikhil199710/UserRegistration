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


        public static string REGEX_EMAIL = "^[a-zA-Z0-9]+([.][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]+([.][a-zA-Z]{2})*$";
        public bool validateEmail(string email)
        {
            return Regex.IsMatch(email, REGEX_EMAIL);
        }


        public static string REGEX_MOBILE = @"\d{2}\s{1}[0-9]{10}";
        public bool validateMobile(string mobile)
        {
            return Regex.IsMatch(mobile, REGEX_MOBILE);
        }


        public static string REGEX_PASSWORD_R1 = @"^[a-zA-Z0-9]{8,}$";
        public bool validatePasswordrule1(string password)
        {
            return Regex.IsMatch(password, REGEX_PASSWORD_R1);
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


            Console.WriteLine("Enter Email id:");
            if (pattern.validateEmail(Console.ReadLine()))
            {
                Console.WriteLine("Email is Valid");
            }
            else
            {
                Console.WriteLine("Email is Invalid");
            }


            Console.WriteLine("Enter valid Mobile Number with your Country Code");
            if (pattern.validateMobile(Console.ReadLine()))
            {
                Console.WriteLine("Mobile Number is Valid");
            }
            else
                Console.WriteLine("Mobile Number is Invalid");


            Console.WriteLine("Enter Password:");
            if (pattern.validatePasswordrule1(Console.ReadLine()))
            {
                Console.WriteLine("Password is Valid");
            }
            else
                Console.WriteLine("Password is Invalid");



        }
    }
}




//using System;
//using System.Text.RegularExpressions;

//namespace Regex_UC
//{
//    class Pattern
//    {
//        public static string REGEX_PASSWORD_R1 = @"^[a-zA-Z0-9]{8,}$";
//        public bool validatePasswordrule1(string password)
//        {
//            return Regex.IsMatch(password, REGEX_PASSWORD_R1);
//        }
//    }
//    class Program
//    {

//        static void Main(string[] args)
//        {
//            Pattern pattern = new Pattern();
//            Console.WriteLine("Enter Password:");
//            if (pattern.validatePasswordrule1(Console.ReadLine()))
//            {
//                Console.WriteLine("Password is Valid");
//            }
//            else
//                Console.WriteLine("Password is Invalid");
//        }
//    }
//}


