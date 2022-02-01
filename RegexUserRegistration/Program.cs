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
        /// Validating first name starting with cap and have atlest 3 characters 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Welcome to User Registration Program\n");
                UserRegistration1();
                Console.ReadLine();
            }
        }
            //Method to perform UserRegistration
            public static void UserRegistration1()
            {
                Console.WriteLine("Enter First Name\n");
                string firstName = Console.ReadLine();
                Console.WriteLine(UserRegistration.ValidateFirstName(firstName));
            }
    }
}
