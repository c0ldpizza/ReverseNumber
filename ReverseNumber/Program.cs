using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What number would you like to reverse?");    //Prompts user to enter a number

            int n = Convert.ToInt16(Console.ReadLine());                    //Reads input from user
            int result = 0;
            int rem;
            while (n > 0)
            {
                rem = n % 10;
                n = n / 10;
                result = result * 10 + rem;
            }

            Console.WriteLine("The result is " + result.ToString());        

            Console.Read();
        }
    }
}
