using System;
using System.Collections.Generic;
using System.Text;

namespace Startliste
{
    class Registration
    { 
        public Registration(string line)
        {
            var lineParts = line.Split(',');
            StartNumber = lineParts[0];
            Name = lineParts[1];
            Club = lineParts[2];
            Nationality = lineParts[3];
            Group = lineParts[4];
            Class = lineParts[5];
        }

        public string StartNumber { get; }
        public string Name { get; }
        public string Club { get; }
        public string Nationality { get; }
        public string Group { get; }
        public string @Class { get; }
    }
}