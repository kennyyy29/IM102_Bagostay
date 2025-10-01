using System;
using System.Collections.Generic;

class Program
{
    // User-defined function to get character frequency
    static Dictionary<char, int> GetCharFrequency(string input)
    {
        Dictionary<char, int> freq = new Dictionary<char, int>();

        foreach (char c in input)
        {
            // Ignore spaces, commas, etc. if not needed
            if (c == ' ' || c == ',') 
                continue;

            if (freq.ContainsKey(c))
                freq[c]++;
            else
                freq[c] = 1;
        }

        return freq;
    }

    static void Main()
    {
        Console.Write("Enter string: ");
        string str = Console.ReadLine();

        Dictionary<char, int> result = GetCharFrequency(str);

        // Print results
        foreach (var kv in result)
        {
            Console.Write($"{kv.Key}={kv.Value}, ");
        }
        Console.WriteLine();
    }
}
