using System;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            var range = 250;
            var counts = new int[range];
            int total = 0;
            string text = "something";
            while (!string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine().ToLower() ?? string.Empty; 
                foreach (var character in text)
                {
                    total++;
                    counts[(int)character]++;
                }
                for (var i = 0; i < range; i++)
                {
                    if (counts[i] > 0)
                    {
                        var character = (char)i;
                        var percent = 100 * (double)counts[i] / total;
                        string output = character + " - " + percent.ToString("F2") + "%";
                        Console.WriteLine(output);
                    }
                }
            }
        }
    }
}