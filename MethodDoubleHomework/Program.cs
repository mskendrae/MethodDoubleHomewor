using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDoubleHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Create a method named "Double" to calculate and return an
            integer number doubled. For example. Double(7) should return 14. */

            Console.WriteLine("Please enter a number to be doubled.");
            int userInput = int.Parse(Console.ReadLine());
            int answer = Double(userInput);
            Console.WriteLine("Your answer is "+ answer+'.');
            Console.ReadLine();

        }//end main method

        static int Double(int number)
        {
            return number = number * 2;
        }

    }//end class
    }//end namespace

