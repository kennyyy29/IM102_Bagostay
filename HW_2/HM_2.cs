using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter row: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter col: ");
            int cols = int.Parse(Console.ReadLine());

            // Create a 2D list
            List<List<double>> numbers = new List<List<double>>();

            double sum = 0;
            int count = 0;

            // Input values
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine($"Row {i + 1}:");

                List<double> row = new List<double>();

                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Enter number{j + 1}: ");
                    double num = double.Parse(Console.ReadLine());

                    row.Add(num);
                    sum += num;
                    count++;
                }

                numbers.Add(row);
            }

            // Output numbers
            Console.WriteLine("\nThe numbers are:");
            foreach (var row in numbers)
            {
                foreach (var num in row)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }

        
            double average = sum / count;
            Console.WriteLine($"\nSum: {sum} ; Average: {average}");

            Console.ReadKey();
        }
    }
    }

