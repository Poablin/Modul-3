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
            var path = @"C:\Users\GET\source\repos\Testeapp\Testeapp\ordliste.txt";
            string[] allLines = File.ReadAllLines(path);
            foreach (var line in allLines)
            {
                var parts = line.Split("\t");
                Console.WriteLine(parts[1]);
            }
        }
    }
}
