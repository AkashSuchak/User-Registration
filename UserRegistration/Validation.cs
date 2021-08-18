using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Validation
    {
        public void FirstAndLastName()
        {
            //Variables
            string firstAndLastName;
            const string REGEX_NAME = "^[A-Z]{1}[A-Za-z]{2,}";
            
            //Display NOTE            
            Console.WriteLine("NOTE : Name start with Capital and has Minimum 3 characters : ");
            
            firstAndLastName = Console.ReadLine();
            
            //Validation
            if (Regex.IsMatch(firstAndLastName, REGEX_NAME) == true)
            {
                Console.WriteLine("Entered Name is Valid ");
            }
            else
            {
                Console.WriteLine("Invalid Input. Try Again!!!");
                FirstAndLastName();
            }
        }
        public void Email()
        {
            //Constant
            const string Regex_EmailId = "^[A-Za-z0-9]+([.+-_][A-Za-z0-9]+)*[@][a-zA-Z0-9]+[.][A-Za-z]+([.][A-Za-z]+)?$";            
            string email = Console.ReadLine();

            if (Regex.IsMatch(email, Regex_EmailId) == true)
            {
                Console.WriteLine("Entered Email-Id is Valid");
            }
            else
            {
                Console.WriteLine("Invalid Email-ID. Try Again!!!");
                Email();
            }
        }
    }
}
