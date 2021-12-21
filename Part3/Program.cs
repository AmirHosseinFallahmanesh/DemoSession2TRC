using System;

namespace Part3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            if (name=="amir")
            {
                Console.WriteLine("Hi Amir");
            }
            else
            {
                Console.WriteLine("Hi Stranger");
            }

            //& |
            Console.WriteLine("Enter C# Mark");
            float cs = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter Unit Test Mark");
            float ut = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter Unit Asp .net Mark");
            float asp = Convert.ToSingle(Console.ReadLine());


            float average = (cs + asp + ut) / 3;
            Console.WriteLine("Your Average is "+average);
            if (average>=10)
            {
                Console.WriteLine("You Passed");
            }
            else
            {
                Console.WriteLine("You Failed");
            }



        }
    }
}
