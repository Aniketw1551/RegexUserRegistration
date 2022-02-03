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
                UserRegisrtation1();
               UserRegistraton userRegisrtation = new UserRegistraton(); // Declaring object
            }
        }
        //Method to perform UserRegistration
        public static void UserRegistration1()
        {
            bool Continue = true;
            while (Continue)
            {
                Console.WriteLine("Choose Option");
                Console.WriteLine("1.First Name 0.Exit\n");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        Continue = false;
                        break;
                    case 1:
                       Console.WriteLine("Enter valid first name");
                        string frstname = Console.ReadLine();
                        userRegistraton.ValidateFName(frstname);
                        break;
                    default:
                        Console.WriteLine("Please check your option");
                        break;
                }
            }
        }
    }
}
