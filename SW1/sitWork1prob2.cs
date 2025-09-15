using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sitwork1prob2
{
    class Program
    {
        static void ConvertCurrency(double dollar)
        {
            double peso = dollar * 57.17;   
            double yen = dollar * 146.67;    

            Console.WriteLine();
            Console.WriteLine($"{"Dollar($)",-15}{"Phil Peso(P)",-15}{"Jpn Yen(¥)",-15}");
            Console.WriteLine($"{dollar,-15:N0}{peso,-15:N2}{yen,-15:N2}");
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a value [$] ): ");
            string input = Console.ReadLine();

            input = input.Replace(",", "");

            double dollar = double.Parse(input);

           
            ConvertCurrency(dollar);

            Console.ReadKey();

        }
    }
}
