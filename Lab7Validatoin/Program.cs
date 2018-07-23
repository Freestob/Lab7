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
            Console.WriteLine("Hello " + userName);
            Console.ReadKey();
            var email = GetUserEmail();
            Console.WriteLine(email);
            Console.ReadLine();


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
            Regex emailRegex = new Regex(@"^(\w{5,30})@(\w{5,10}).(\w{2,3}$)");
            if(emailRegex.IsMatch(email))
            {
                return email;
            }
            else
            {
                return GetUserEmail();
            }
        }
    }
}
