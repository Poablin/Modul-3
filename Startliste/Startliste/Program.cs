using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Startliste
{
    class Program
    {
        static void Main(string[] args)
        {
            var model = new Model();
            
            using var stream = new StreamReader("startlist.csv");
            string headerLine = stream.ReadLine();
            string line;
            while ((line = stream.ReadLine()) != null)
            {
                line = stream.ReadLine();
                model.HandleLine(line);
            }

            foreach (var club in model.Clubs)
            {
                Console.WriteLine(club.Name);
            }
        }
    }
}