/*Name: Vikramjeet Singh
Purpose Palindrome Checker*/
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome_checker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************Palindrome checker***************\n");

            Console.Write("Please enter the first letter: ");
            string char1 = Console.ReadLine().ToLower();
            Console.Write("Please enter the second letter: ");
            string char2 = Console.ReadLine().ToLower();
            Console.Write("Please enter the third letter: ");
            string char3 = Console.ReadLine().ToLower();

            if (char2 != "a" && char2 != "e" && char2 != "i" && char2 != "o" && char2 != "u")
                Console.WriteLine("Your characters dont make a valid word...");
            else

            if (char1 == char3)
                Console.WriteLine("Your characters form a proper palindrome...");
            else
                Console.WriteLine("Your characters DO NOT forms a proper palindrome...");


            Console.WriteLine("Application finished...");
            Console.ReadLine();
        }
    }
}
