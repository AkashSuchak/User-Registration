using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            //Display Message
            Console.WriteLine("Welcome to User Registration !");
            Console.WriteLine("==============================");

            //Call Validation Class
            Validation validation = new Validation();

            /*Console.WriteLine("Enter Your First Name : ");
            validation.FirstAndLastName();//FirstName
            Console.WriteLine("------------------------");
            
            Console.WriteLine("Enter Your Last Name : ");
            validation.FirstAndLastName();//LastName            
            Console.WriteLine("------------------------");            
            
            Console.WriteLine("Enter your Email-Id : ");
            validation.Email();
            Console.WriteLine("------------------------");            
            */
            Console.WriteLine("Enter your Mobile Number : ");
            validation.MobileNumber();
            Console.WriteLine("------------------------");
        }
    }
}
