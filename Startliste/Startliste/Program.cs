using System;
using System.Collections.Generic;
using System.IO;

namespace Startliste
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Registration>();

            using (var file = new StreamReader("startlist.csv"))
            {
                string header = file.ReadLine();
                string line;

                while ((line = file.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}