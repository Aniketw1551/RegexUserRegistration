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
        /// Validating last name starting with cap and have atlest 3 characters 
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
            bool Continue = true;
            while (Continue)
            {
                Console.WriteLine("Choose Option");
                Console.WriteLine("1.First Name 2.Last Name 0.Exit\n");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        Continue = false;
                        break;
                    case 1:
                        Console.WriteLine("Enter First Name");
                        string firstName = Console.ReadLine();
                        Console.WriteLine(UserRegistration.ValidateFirstName(firstName));
                        break;
                    case 2:
                        Console.WriteLine("Enter Last Name");
                        string lastName = Console.ReadLine();
                        Console.WriteLine(UserRegistration.ValidateLastName(lastName));
                        break;
                }
            }
        }
    }
}
