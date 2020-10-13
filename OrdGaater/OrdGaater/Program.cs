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

           var randomWord = words[new Random().Next(0, words.Length)];

           var firstWord = string.Empty;
           var secondWord = string.Empty;
           foreach (var word in words)
           {
               if (randomWord.Substring(randomWord.Length - 3) == word.Substring(0, 3))
               {
                   firstWord = randomWord;
                    secondWord = word;
               }

               else if (randomWord.Substring(randomWord.Length - 4) == word.Substring(0, 4))
               {
                   firstWord = randomWord;
                   secondWord = word;
               }

               else if (randomWord.Substring(randomWord.Length - 5) == word.Substring(0, 5))
               {
                   firstWord = randomWord;
                   secondWord = word;
               }
           }

           Console.WriteLine("Første ord: " + firstWord + "  " + "Andre ord:" + secondWord);

        }

        private static string[] ReturnWords()
        {
            var path = @"C:\Users\krist\Documents\GitHub\Modul-3\OrdGaater\OrdGaater\ordliste.txt";
            var lastWord = string.Empty;
            var list = new List<string>();
            foreach (var line in File.ReadAllLines(path))
            {
                var parts = line.Split("\t");
                var word = parts[1];
                if (word != lastWord && !word.Contains("-") && !word.Contains(" ") && word.Length > 6) list.Add(word);
                lastWord = word;
            }

            return list.ToArray();
        }
    }
}
