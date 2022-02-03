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
        /// Validating first name starting with cap letter and have atlest 3 characters 
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
                Console.WriteLine("Enter last name");
                string lastname = Console.ReadLine();
                userRegistration.ValidateLName(lastname);
            }
        }
    }
}