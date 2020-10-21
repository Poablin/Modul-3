namespace Startliste
{
    class Club
    {
        public Club(string clubName, Registration registrations)
        {
            ClubName = clubName;
            Registrations = registrations;
        }
        public string ClubName { get; }
        public Registration Registrations { get; }

    }
}