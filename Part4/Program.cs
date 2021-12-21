using System;

namespace Part4
{
    class Program
    {
        static void Main(string[] args)
        {
            //username admin
            //password 123

            Console.WriteLine("Enter Username");
            string username = Console.ReadLine();

            Console.WriteLine("Enter Password");
            string password = Console.ReadLine();

            if (username=="admin" && password=="123")
            {
                Console.WriteLine("Welcome To My App");
            }
            else
            {
                Console.WriteLine("Username or Password Not Found");
            }


        }
    }
}
