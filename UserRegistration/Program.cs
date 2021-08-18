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
            validation.FirstName();
        }
    }
}
