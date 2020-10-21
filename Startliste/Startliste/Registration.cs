using System;
using System.Collections.Generic;
using System.Text;

namespace Startliste
{
    class Registration
    { 
        public Registration(string startNumber, string name, string club, string nationality, string @group, string @class)
        {
            StartNumber = startNumber;
            Name = name;
            Club = club;
            Nationality = nationality;
            Group = @group;
            Class = @class;
        }

        public string StartNumber { get; }
        public string Name { get; }
        public string Club { get; }
        public string Nationality { get; }
        public string Group { get; }
        public string @Class { get; }
    }
}
