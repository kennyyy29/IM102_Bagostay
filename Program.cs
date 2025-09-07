using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            Console.WriteLine("PALINDROME CHECKER");

            while (true)
            {
                Console.Write("Enter string: ");
                input = Console.ReadLine();

                bool valid = true;
                if (string.IsNullOrWhiteSpace(input))
                    valid = false;
                else
                {
                    foreach (char c in input)
                    {
                        if (!char.IsLetter(c))
                        {
                            valid = false;
                            break;
                        }
                    }
                }

                if (!valid)
                    break;

                
                string original = input;
                string lowerInput = input.ToLower();
                string reversed = "";
                for (int i = lowerInput.Length - 1; i >= 0; i--)
                {
                    reversed += lowerInput[i];
                }

                
                bool isPalindrome = true;
                for (int i = 0; i < lowerInput.Length; i++)
                {
                    if (lowerInput[i] != reversed[i])
                    {
                        isPalindrome = false;
                        break;
                    }
                }

                // Display result
                Console.WriteLine();
                Console.WriteLine("Original String         Reversed String            Palindrome?");
                Console.WriteLine($"  {original,-20} {reversed,-25} {(isPalindrome ? "Yes" : "No")}");
                Console.WriteLine();
            }

            Console.WriteLine("//End execution");
            Console.ReadKey();
        }
    }
}
        
    

