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
                int n = Convert.ToInt16(inputNum);                          //Checks to make sure the user entered an integer

                int result = 0;                                             //Function to reverse an integer
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
                Console.WriteLine("Error: " + e.Message + " Please enter an integer.");     //Prompts the user if they enter a non-integer
                Console.Read();
            }
                       
        }
    }
}
