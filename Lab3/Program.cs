using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {

            int userNumber;
            string userName;
            string willContinue = "y";

            Console.WriteLine("Hey there, what's your name?");
            userName = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Hello " + userName +", please enter number from 1 - 100.  ");
            
            userNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            while (willContinue == "y")

            {
                if (userNumber >= 101)
                {
                    Console.WriteLine("Come on, read the directions " + userName + "!");
                }

                else if (userNumber % 2 == 0 && userNumber >= 2 && userNumber <=24)
                {
                    Console.WriteLine(userNumber + " : That number is even and less than 25.");
                }

                else if (userNumber % 2 == 0)
                {
                    Console.WriteLine(userNumber + " : That number is even.");
                }
                else if (userNumber % 2 == 0 && userNumber >= 25 && userNumber <= 60)
                {
                    Console.WriteLine(userNumber + " : That number is even.");
                }
                else if (userNumber % 2 == 0 && userNumber >= 61)
                {
                    Console.WriteLine(userNumber + " : That number is even.");
                }
                else if (userNumber >= 1 && userNumber <= 100)
                {
                    Console.WriteLine(userNumber + " : That number is odd.");
                }
                else if (userNumber >= 1 && userNumber <= 100)
                {
                    Console.WriteLine(userNumber + " : That number is odd.");
                }
                
                
                    Console.WriteLine("");
                    Console.WriteLine("Would you like to enter another number?  y or n");
                    willContinue = Console.ReadLine();
                    Console.WriteLine("");

                if ( willContinue == "y")
                {   Console.WriteLine("Please enter a new number.");
                    userNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("");
                }

            }
            Console.WriteLine("Thank you for participating " + userName + ".");

            
        }
    }
}
