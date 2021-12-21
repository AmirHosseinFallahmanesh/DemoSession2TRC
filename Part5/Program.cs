using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter C# Mark");
            float cs = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter Unit Test Mark");
            float ut = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter Unit Asp .net Mark");
            float asp = Convert.ToSingle(Console.ReadLine());


            float average = (cs + asp + ut) / 3;
            Console.WriteLine("Your Average is " + average);


            // 0 5  E
            //5  10 D
            //10 15  C
            //15  20 B
            //20     A

            if (average>=0 && average<5)
            {
                Console.WriteLine("Your Grade is E");
            }
            else if (average>=5 && average<10)
            {
                Console.WriteLine("Your Grade is D");
            }
            else if (average >= 10 && average < 15)
            {
                Console.WriteLine("Your Grade is C");
            }
            else if (average >= 15 && average < 20)
            {
                Console.WriteLine("Your Grade is B");
            }
            else if (average==20)
            {
                Console.WriteLine("Your Grade is A");
            }
            else
            {
                Console.WriteLine("Average Invalid Try Again");
            }

            Console.ReadKey();
            
        }
        
    }
}
