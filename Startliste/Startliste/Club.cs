using System.Collections.Generic;

namespace Startliste
{
    class Club
    {
        public string Name { get; }
        public List<RegistrationModel> Registrations { get; }

        public Club(string name)
        {
            Name = name;
            Registrations = new List<RegistrationModel>();
        }

        public void Add(RegistrationModel registration)
        {
            Registrations.Add(registration);
        }
    }
}