using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexUserRegistration
{
    public class Program
    {
        /// <summary>
        /// Validating Password Rule 2
        /// </summary>
        /// <param name="args">The args.</param>
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Welcome to User Registration Program\n");
                UserRegistration userRegistration = new UserRegistration(); // Declaring object
                //Console.WriteLine("Enter valid first name");
                //string firstname = Console.ReadLine();
                //userRegistration.ValidateFName(firstname);
                //Console.WriteLine("Enter last name");
                //string lastname = Console.ReadLine();
                //userRegistration.ValidateLName(lastname);
                //Console.WriteLine("Enter Email id");
                //string email = Console.ReadLine();
                //userRegistration.ValidateEmail(email);
                //Console.WriteLine("Enter Mobile no");
                //string monumber = Console.ReadLine();
                //userRegistration.ValidateMobileNumber(monumber);
                //Console.WriteLine("Enter Password");
                //string password1 = Console.ReadLine();
                //userRegistration.ValidatePasswordRule1(password1);
                // Console.WriteLine("Enter Password");
                //string password1 = Console.ReadLine();
                //userRegistration.ValidatePasswordRule1(password1);
                Console.WriteLine("Enter password with atleast one upper case letter");
                string password2 = Console.ReadLine();
                userRegistration.ValidatePasswordRule2(password2);
            }
        }
    }
}