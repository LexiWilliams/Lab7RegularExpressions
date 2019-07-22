using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab7RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ValidateName("What is your name?"));
            Console.WriteLine(ValidateEmail("What is your email?"));
            Console.WriteLine(ValidatePhoneNumber("What is your phone number?"));
            Console.WriteLine(ValidateDate("What is the date today? mm/dd/yyyy"));
            Console.WriteLine(ValidateHTML("Gimme an HTML element."));
        }

        public static string ValidateName(string message)
        {
            Console.WriteLine(message);
            string name = Console.ReadLine();
            if (Regex.IsMatch(name, @"^[A-Z][a-z]{0,29}$"))
            {
                return $"{name} is a valid name!";
            }
            else
            {
                Console.WriteLine("That name is invalid.");
                return ValidateName(message);
            }
        }

        public static string ValidateEmail(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            if (Regex.IsMatch(input, @"^[a-zA-Z0-9]{5,30}[@]{1}[a-zA-Z0-9]{5,10}[.]{1}[a-zA-Z0-9]{2,3}$"))
            {
                return $"{input} is a valid email!";
            }
            else
            {
                Console.WriteLine("That email is invalid.");
                return ValidateEmail(message);
            }
        }

        public static string ValidatePhoneNumber(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            if (Regex.IsMatch(input, @"^[0-9]{3}[-]{1}[0-9]{3}[-]{1}[0-9]{4}$"))
            {
                return $"{input} is a valid phone number!";
            }
            else
            {
                Console.WriteLine("That phone number is invalid.");
                return ValidatePhoneNumber(message);
            }
        }

        public static string ValidateDate(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            if (Regex.IsMatch(input, @"^[0-1]{1}[0-2]{1}[/]{1}[0-3]{1}[0-9]{1}[/]{1}[0-9]{4}$"))
            {
                return $"{input} is a valid date.";
            }
            else
            {
                Console.WriteLine("That date is invalid.");
                return ValidateDate(message);
            }
        }

        public static string ValidateHTML(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            if (Regex.IsMatch(input, @"^[<]{1}[/]*[a-zA-Z0-9]+[>]{1}[\s]*[<]{1}[/]*[a-zA-Z0-9]+[>]{1}$"))
            {
                return $"{input} is valid html element!";
            }
            else
            {
                Console.WriteLine("That HTML is invalid.");
                return ValidateHTML(message);
            }
        }
    }
}
