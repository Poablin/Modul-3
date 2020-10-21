using System;
using System.Collections.Generic;
using System.IO;

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
                model.LineBuilder(line);
            }
        }
    }
}