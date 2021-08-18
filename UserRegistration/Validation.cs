using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Validation
    {
        public void FirstName()
        {
            //Variables
            string firstName;
            const string REGEX_NAME = "^[A-Z]{1}[A-Za-z]{2,}";
            
            //Display NOTE            
            Console.WriteLine("NOTE : First name start with Capital and has Minimum 3 characters : ");
            Console.Write("Enter Your First name : ");
            firstName = Console.ReadLine();
            
            //Validation
            if (Regex.IsMatch(firstName, REGEX_NAME) == true)
            {
                Console.WriteLine("Entered First Name is Valid ");
            }
            else
            {
                Console.WriteLine("Invalid Input. Try Again!!!");
                FirstName();
            }
        }
    }
}
