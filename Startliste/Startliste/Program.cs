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
            using (var stream = new StreamReader("startlist.csv"))
            {
                string line;
                while ((line = stream.ReadLine()) != null)
                {
                    var str = line;
                    var stringArray = str.Split(',');
                    var registration = new Registration(stringArray[0], stringArray[1], stringArray[2], stringArray[3], stringArray[4], stringArray[5]);
                    list.Add(registration);
                }

                foreach (var content in list)
                {
                    Console.WriteLine(content.Name);
                }
            }
        }
    }
}