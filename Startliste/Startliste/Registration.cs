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

        public string StartNumber { get; private set; }
        public string Name { get; private set; }
        public string Club { get; private set; }
        public string Nationality { get; private set; }
        public string Group { get; private set; }
        public string @Class { get; private set; }
    }
}
