using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexUserRegistration
{
    public class UserRegistration
    {
        //Pattern for first name
        public const string FIRST_NAME = "^[A-Z][a-zA-Z]{2}";

        //Method to Validate First Name
        public void ValidateFName(string fName)
        {
            //using regex constructor and assigning pattern
            Regex regex = new Regex(FIRST_NAME);

            if (regex.IsMatch(fName))
            {
                Console.WriteLine("first name is matched with pattern");
            }
            else
            {
               Console.WriteLine("first name does not match with pattern");
            }
        }
    }
}
