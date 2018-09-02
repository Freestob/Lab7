using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Lab7Validatoin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This will validate different kinds of input");

            var userName = GetUserName();
            var email = GetUserEmail();
            var phone = GetPhoneNumber();
            var date = GetDate();
            Console.WriteLine($"Hello {userName} your email is {email}, your phone number is {phone} and you entered the date {date}.");
            Console.ReadKey();


        }
        static string GetUserName()
        {
            Console.WriteLine("Please enter in your first name.");
            string userName = Console.ReadLine();
            Regex nameRegex = new Regex(@"^[A-Z][a-z]\D{0,30}$");
            if (nameRegex.IsMatch(userName))
            { 
                return userName;
            }
            else
            {
                return GetUserName();
            }

        }
        static string GetUserEmail()
        {
            Console.WriteLine("Please enter your email");
            string email = Console.ReadLine();
            Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if(emailRegex.IsMatch(email))
            {
                return email;
            }
            else
            {
                return GetUserEmail();
            }
        }
        static string GetPhoneNumber()
        {
            Console.WriteLine("Please enter your phone number as xxx-xxx-xxxx");
            string phoneNumber = Console.ReadLine();
            Regex phoneRegex = new Regex(@"^(\d{3,3})-(\d{3,3})-(\d{4,4}$)");
            if (phoneRegex.IsMatch(phoneNumber))
            {
                return phoneNumber;
            }
            else
            {
                return GetPhoneNumber();
            }
        }
        static string GetDate()
        {
            Console.WriteLine("Please enter a date as dd/mm/yyyy");
            string date = Console.ReadLine();
            Regex dateRegex = new Regex(@"^(\d{2,2})/(\d{2,2})/(\d{4,4}$)");
            if (dateRegex.IsMatch(date))
            {
                return date;
            }
            else
            {
                return GetDate();
            }
        }
    }
}
