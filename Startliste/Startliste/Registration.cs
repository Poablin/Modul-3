using System;
using System.Collections.Generic;
using System.Text;

namespace Startliste
{
    class Registration
    {
        public int StartNumber { get; private set; }
        public string Name { get; private set; }
        public string Club { get; private set; }
        public string Nationality { get; private set; }
        public string Group { get; private set; }
        public string Class { get; private set; }

        public Registration(int startNumber, string name, string club, string nationality, string @group, string @class)
        {
            StartNumber = startNumber;
            Name = name;
            Club = club;
            Nationality = nationality;
            Group = @group;
            Class = @class;
        }
}
}
