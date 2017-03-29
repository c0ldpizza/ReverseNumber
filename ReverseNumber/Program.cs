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

            String inputNum = Console.ReadLine();                           //Reads input from user

            try
            {
                int n = Convert.ToInt16(inputNum);
                int result = 0;
                int rem;
                while (n > 0)
                {
                    rem = n % 10;
                    n = n / 10;
                    result = result * 10 + rem;
                }

                Console.WriteLine("The result is " + result.ToString());        //Returns result to user

                Console.Read();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message + " Please enter an integer.");
                Console.Read();
            }
                       
        }
    }
}
