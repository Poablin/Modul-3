using System.Collections.Generic;

namespace Startliste
{
    class Club
    {
        public string Name { get; }
        public List<Registration> Registrations { get; }

        public Club(string name)
        {
            Name = name;
            Registrations = new List<Registration>();
        }

        public void Add(Registration registration)
        {
            Registrations.Add(registration);
        }
    }
}