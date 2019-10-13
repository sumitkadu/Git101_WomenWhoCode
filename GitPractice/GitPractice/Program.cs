using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number: ");
            decimal n1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            decimal n2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");            
            Console.WriteLine("Enter your choice: ");
            var choice = Convert.ToDecimal(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    Console.WriteLine(Add(n1, n2));
                    break;
                case 2:
                    Console.WriteLine(Subtract(n1, n2));
                    break;
                case 3:
                default:
                    return;
            }

            Console.ReadKey();

        }

        private static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        private static decimal Subtract(decimal a, decimal b)
        {
            return a - b;
        }
    }
}
