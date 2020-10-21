namespace Startliste
{
    class Club
    {
        public Club(string name)
        {
            Name = name;
        }

        public string Name { get; }
        public Registration Registrations { get; set; }

    }
}