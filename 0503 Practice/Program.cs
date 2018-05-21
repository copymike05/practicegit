using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0503_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your favorite number?");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick another random number.");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The numbers you picked are " + a + " and " + b);
            int c = a + b;
            Console.WriteLine("The sum of these numbers is " + c);
            Console.WriteLine("Additional code has been added.");
            Console.ReadKey();
        }
    }
}
