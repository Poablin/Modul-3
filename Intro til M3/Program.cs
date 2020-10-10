using System;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadTextAndShowCharCounts(250);
        }

        private static void ReadTextAndShowCharCounts(int range)
        {
            var counts = new int[range];
            int total = 0;
            string text = "something";
            while (!string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine().ToLower();
                total = CountChars(text, total, counts);
                ShowCounts(range, counts, total);
            }
        }

        private static void ShowCounts(int range, int[] counts, int total)
        {
            for (var i = 0; i < range; i++)
            {
                if (counts[i] <= 0) continue;
                var character = (char) i;
                var percent = 100 * (double) counts[i] / total;
                string output = character + " - " + percent.ToString("F2") + "%";
                Console.WriteLine(output);
            }
        }

        private static int CountChars(string text, int total, int[] counts)
        {
            foreach (var character in text)
            {
                total++;
                counts[(int) character]++;
            }

            return total;
        }
    }
}