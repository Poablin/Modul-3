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
           var words = ReturnWords();
           Console.WriteLine(words[0]);
           foreach (var word in words)
           {
               Console.WriteLine(word);
           }
        }

        private static string[] ReturnWords()
        {
            var path = @"C:\Users\GET\source\repos\Modul-3\OrdGaater\OrdGaater\ordliste.txt";
            var lastWord = string.Empty;
            var list = new List<string>();
            foreach (var line in File.ReadAllLines(path))
            {
                var parts = line.Split("\t");
                var word = parts[1];
                if (word != lastWord && !word.Contains("-") && !word.Contains(" ") && word.Length > 3) list.Add(word);
                lastWord = word;
            }

            return list.ToArray();
        }
    }
}
