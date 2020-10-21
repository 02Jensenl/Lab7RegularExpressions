using System;
using System.Text.RegularExpressions;


namespace Lab7Regex
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine(ValidName("Please enter a valid name."));
            Console.WriteLine(ValidEmail("Please enter a valid email"));
            Console.WriteLine(PhoneNumber("Please enter a valid phone number: (xxx-xxx-xxxx)"));
            Console.WriteLine(ValidDate("Please enter a valid date: dd/mm/yyyy"));


        }

        public static string ValidName(string message)
        {
            Console.WriteLine(message);
            string name = Console.ReadLine();
            if (Regex.IsMatch(name, @"^([A-Z][a-z]+([ ]?[a-z]?['-]?[A-Z][a-z]+)*){1,30}$"))

            {
                return "Name is valid.";
            }
            else
            {
                Console.WriteLine("Sorry, name is not valid!");
                return ValidName(message);
            }

        }

        public static string ValidEmail(string email)
        {
            Console.WriteLine("Please enter a valid email:");
            string emailAdd = Console.ReadLine();
            if (Regex.IsMatch(emailAdd, @"^\b[\w]{5,30}@[\w\.-]{5,10}\.\w{2,4}\b"))

            {
                return "Email is valid.";
            }
            else
            {
                Console.WriteLine("Sorry, email is not valid.");
                return ValidEmail(email);
            }
            
        }
        public static string PhoneNumber(string pNumber)
        {
            Console.WriteLine(pNumber);
            string pNum = Console.ReadLine();
            if (Regex.IsMatch(pNum, @"^(\d{3})(?:[-])(\d{3})[-](\d{4})$"))

            {
                return "Phone number is valid.";
            }
            else
            {
                Console.WriteLine("Sorry, phone number is not valid.");
                return PhoneNumber(pNumber);
            }
        }
            public static string ValidDate(string date)
            {
                Console.WriteLine(date);
                string vDate = Console.ReadLine();
                if (Regex.IsMatch(vDate, @"^([0]?[1-9]|[1|2][0-9]|[3][0|1])[/-]([0]?[1-9]|[1][0-2])[/-]([0-9]{4}|[0-9]{2})$"))

                {
                    return "Date is valid";
                }
                else
                {
                    Console.WriteLine("Sorry, date is not valid.");
                    return ValidDate(vDate);
                }
            }
        }
    }
