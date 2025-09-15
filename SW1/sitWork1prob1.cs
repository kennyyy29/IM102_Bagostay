using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class program
{
    static string PrimeOrComposite(int num)
    {
        if (num <= 1)
            return "Composite"; 

        for (int i = 2; i <= num / 2; i++)
        {
            if (num % i == 0) 
                return "Composite";
        }

        return "Prime";
    }

    static void Main()
    {
        int number = 5;
        int count = 1;
        int[] num = new int[number];
        for (int i = 0; i < number; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            num[i] = int.Parse(Console.ReadLine());

           
            count++;
        }
        foreach (int ram in num)
        {
            string result = PrimeOrComposite(ram);

            Console.WriteLine($"{count}. {ram,-5} {result}");
        }
        Console.ReadKey();
    }
}





