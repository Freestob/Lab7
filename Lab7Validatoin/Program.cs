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
            Console.WriteLine(userName);
            Console.ReadKey();
        }
        static string GetUserName()
        {
            Console.WriteLine("Please enter in your name");
            string userName = Console.ReadLine();
            Regex nameRegex = new Regex(@"[a-z]\D");
            if (nameRegex.IsMatch(userName))
            { 
                return userName;
            }
            else
            {
                return GetUserName();
            }
        }
    }
}
