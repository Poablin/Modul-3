using System;
using System.Collections.Generic;

namespace Startliste
{
    class Model
    {
        public List<Club> Clubs { get; set; }
        public List<Registration> Registrations { get; set; }

        public void LineBuilder(string line)
        {
            var registration = new Registration(line);
        }
    }
}