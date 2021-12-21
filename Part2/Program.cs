using System;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter Name");
            //string name= Console.ReadLine();
            //Console.WriteLine("Enter Surname");
            //string surname = Console.ReadLine();
            //Console.WriteLine("Hello "+name+" "+surname);


            //int number1 = 12;
            //int number2 = 9;
            //Console.WriteLine(number1+number2);
            //Console.WriteLine(number1-number2);
            //Console.WriteLine(number1*number2);
            //Console.WriteLine(number1/number2);
            //Console.WriteLine(number1%number2);


            //implicity cast
            int n = 12;
            double d = n;

            //explicity cast
            double d1 = 12.2;
            int n1 = (int)d1;


            int number = Convert.ToInt32("45");
            float numberF = Convert.ToSingle("45.21");



            Console.WriteLine("Enter Number1");
            int number1 =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Enter Number2");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int result = number1 + number2;
            Console.WriteLine("The Result is "+result);














        }
    }
}
