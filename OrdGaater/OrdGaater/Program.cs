using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualBasic.FileIO;

namespace Testeapp
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\GET\source\repos\Modul-3\OrdGaater\OrdGaater\ordliste.txt";
            string[] allLines = File.ReadAllLines(path);
            MakeListFromWords(allLines);
        }

        private static void MakeListFromWords(string[] allLines)
        {
            var lastWord = string.Empty;
            foreach (var line in allLines)
            {
                var parts = line.Split("\t");
                var word = parts[1];
                if (word!=lastWord) Console.WriteLine(word);
                lastWord = word;
            }
        }
    }
}
