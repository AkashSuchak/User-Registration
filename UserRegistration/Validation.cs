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
            const string REGEX_EMAIL_ID = @"^[A-Za-z0-9]+([\.+\-_][A-Za-z0-9]+)*@[a-zA-Z0-9]+\.?[A-Za-z]+\.?[A-Za-z]{2,}$";
            string[] email = new string[] {
            "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc-100@abc.net",
            "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com", "abc","abc@.com.my",
            "abc123@gmail.a", "abc123@.com", "abc123@.com.com", ".abc@abc.com", "abc()*@gmail.com",
            "abc@%*.com", "abc..2002@gmail.com", "abc.@gmail.com", "abc@abc@gmail.com", "abc@gmail.com.1a",
            "abc@gmail.com.aa.au"
            };
            for (int i = 0; i < email.Length; i++)
            {
                if (Regex.IsMatch(email[i], REGEX_EMAIL_ID) == true)
                {
                    Console.WriteLine("Valid : {0}", email[i]);
                }
                else
                {
                    Console.WriteLine("Invalid : {0}", email[i]);
                    //Email();
                }
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
            const string REGEX_PASSWORD = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[~`!@#$%^&*_+=,./?]).{8,}$";
                        
            Console.WriteLine("NOTE : Password Rule 1 --> Minimum 8 Characters");
            Console.WriteLine("       Password Rule 2 --> Atleast 1 Upper Case");
            Console.WriteLine("       Password Rule 3 --> Atleast 1 Numeric Number");
            Console.WriteLine("       Password Rule 4 --> Atleast 1 Special Character");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Enter Your Password : ");

            //Take User Input
            string password = Console.ReadLine();

            //Validation an Display
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
