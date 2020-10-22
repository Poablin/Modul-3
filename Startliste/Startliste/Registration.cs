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
            StartNumber = lineParts[0].Trim('"');
            Name = lineParts[1].Trim('"');
            Club = lineParts[2].Trim('"');
            Nationality = lineParts[3].Trim('"');
            Group = lineParts[4].Trim('"');
            Class = lineParts[5].Trim('"');
        }
        public string StartNumber { get; private set; }
        public string Name { get; private set; }
        public string Club { get; private set; }
        public string Nationality { get; private set; }
        public string Group { get; private set; }
        public string @Class { get; private set; }
    }
}