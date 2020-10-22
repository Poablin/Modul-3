using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Startliste
{
    class Program
    {
        static void Main(string[] args)
        {
            var model = new Model();
            
            CreateRegistrationLists(model);
            
            while (true) {
                Console.Write("Skriv inn nummber på klubb" + "\n");
                var clubNoString = Console.ReadLine();
                var clubNo = Convert.ToInt32(clubNoString);
                var clubIndex = clubNo - 1;
                var selectedClub = model.Clubs[clubIndex];

                Console.WriteLine("\n" + "Alle registrerte i klubben:");
                foreach (var registration in selectedClub.Registrations)
                {
                    Console.WriteLine(registration.Name);
                }
            }
        }

        private static void CreateRegistrationLists(Model model)
        {
            using var stream = new StreamReader("startlist.csv");
            string headerLine = stream.ReadLine();
            string line;
            while ((line = stream.ReadLine()) != null)
            {
                line = stream.ReadLine();
                model.HandleLine(line);
            }

            for (var index = 0; index < model.Clubs.Count; index++)
            {
                var no = index + 1;
                var club = model.Clubs[index];
                Console.WriteLine(no + " " + club.Name);
            }
        }
    }
}