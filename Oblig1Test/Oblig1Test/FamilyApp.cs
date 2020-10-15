using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace Oblig1Test
{
    public class FamilyApp
    {
        public List<Person> _people;
        public FamilyApp(params Person[] people)
        {
            _people = new List<Person>(people);
        }
        internal string WelcomeMessage = "Hei! Welkommen til Family Appen!";
        internal string CommandPrompt = "Commandoene er hjelp, liste og vis \n";

        public object HandleCommand(string command)
        {
            string str = "";
            if (command == "hjelp")
            {
                str += @"hjelp => viser en hjelpetekst som forklarer alle kommandoene
liste => lister alle personer med id, fornavn, fødselsår, dødsår og navn og id på mor og far om det finnes registrert.
vis<id> => viser en bestemt person med mor, far og barn(og id for disse, slik at man lett kan vise en av dem)";
            }

            if (command == "liste")
            {
                
                foreach (var person in _people)
                {
                  str += person.GetDescription() + "\n";
                }
            }

            if (command.Substring(0, 3) == "vis")
            {
                int searchId = int.Parse(command.Substring(command.Length - 1));
                foreach (var person in _people)
                {
                    if (person.Id == searchId)
                    {
                        str += person.GetDescription();
                    }
                }
            }

            return str;
        }
    }
}