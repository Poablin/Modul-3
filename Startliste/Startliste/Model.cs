using System;
using System.Collections.Generic;
using System.Linq;

namespace Startliste
{
    class Model
    { 
        public Model()
        {
            Clubs = new List<Club>();
            Registrations = new List<Registration>();
        }
        public List<Club> Clubs { get; private set; }
        public List<Registration> Registrations { get; private set; }

        public void HandleLine(string line)
        {
            var registration = new Registration(line);
            Registrations.Add(registration);

            var club = Clubs.FirstOrDefault(club => club.Name == registration.Club);
            if (club == null)
            {
                club = new Club(registration.Club);
                Clubs.Add(club);
            }

            club.Add(registration);
        }
    }
}