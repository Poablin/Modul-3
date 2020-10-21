namespace Startliste
{
    class Club
    {
        public Club(string clubName, Registration registrations)
        {
            ClubName = clubName;
            Registrations = registrations;
        }
        public string ClubName { get; private set; }
        public Registration Registrations { get; private set; }

    }
}
