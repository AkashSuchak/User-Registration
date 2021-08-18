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
            const string REGEX_EMAIL_ID = "^[A-Za-z0-9]+([.+-_][A-Za-z0-9]+)*[@][a-zA-Z0-9]+[.][A-Za-z]+([.][A-Za-z]+)?$";            
            string email = Console.ReadLine();

            if (Regex.IsMatch(email, REGEX_EMAIL_ID) == true)
            {
                Console.WriteLine("Entered Email-Id is Valid");
            }
            else
            {
                Console.WriteLine("Invalid Email-ID. Try Again!!!");
                Email();
            }
        }
        public void MobileNumber()
        {
            //Constant
            const string REGEX_MOBILE_NUMBER = "^[1-9]{1,2}[ ][1-9]{1}[0-9]{9}$";
            Console.WriteLine("Example :: 91 9876543210 :: ");
            
            //Take Input from User
            string mobile = Console.ReadLine();

            //validation
            if (Regex.IsMatch(mobile, REGEX_MOBILE_NUMBER) == true)
            {
                Console.WriteLine("Entered Mobile number is Valid. ");
            }
            else
            {
                Console.WriteLine("Invalid Mobile Number. Try Again !!!");
                MobileNumber();
            }

        }
        public void Password()
        {
            //Constant
            const string REGEX_PASSWORD = "^[a-zA-Z0-9_!-+@#$]{8,}$";
            Console.WriteLine("NOTE : Password Rule 1 --> Minimum 8 Characters");            
            
            //Take User Input
            string password = Console.ReadLine();

            //Validation
            if (Regex.IsMatch(password, REGEX_PASSWORD) == true)
            {
                Console.WriteLine("Valid Password. ");
            }
            else
            {
                Console.WriteLine("Invalid Password. Try AGain !!!");
                Password();
            }
        }
    }
}
