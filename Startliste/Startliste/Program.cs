using System;
using System.Collections.Generic;
using System.IO;

namespace Startliste
{
    class Program
    {
        static void Main(string[] args)
        {
            var registrationList = new List<Registration>();
            var clubList = new List<Club>();

            using var stream = new StreamReader("startlist.csv");
            string line;
            while ((line = stream.ReadLine()) != null)
            {
                var str = line;
                var stringArray = str.Split(',');
                var registration = new Registration(stringArray[0], stringArray[1], stringArray[2], stringArray[3], stringArray[4], stringArray[5]);
                registrationList.Add(registration);
            }

            foreach (var registration in registrationList)
            {
                if (registration.Club != "\"\"" && registration.Club != "\"Club\"")
                {
                    var newClub = new Club(registration.Club, registration);
                    clubList.Add(newClub);
                }
            }

            foreach (var club in clubList)
            {
                Console.WriteLine(club.ClubName);
            }
        }
    }
}