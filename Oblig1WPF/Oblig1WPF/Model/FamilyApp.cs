using System.Collections.Generic;
using System.Linq;

namespace Oblig1WPF.Model
{
    public class FamilyApp
    {
        public List<Person> People;

        public FamilyApp(params Person[] people)
        {
            People = new List<Person>(people);
        }

        internal string WelcomeMessage = "Hei! Welkommen til Family Appen!";
        internal string CommandPrompt = "Commandoene er hjelp, liste og vis \n";

        public object HandleCommand(string command)
        {
            var childrenSearchId = 0;
            var str = "";
            if (command == "hjelp")
                str += "\nhjelp => viser en hjelpetekst som forklarer alle kommandoenliste\n" +
                       "liste => lister alle personer med id, fornavn, fødselsår, dødsår og navn og id på mor og far om det finnes registrert.\n" +
                       "vis <id> => viser en bestemt person med mor, far og barn(og id for disse, slik at man lett kan vise en av dem)\n";
            if (command == "liste")
                str = People.Aggregate(str, (current, person) => current + person.GetDescription() + "\n");
            if (command.Substring(0, 3) == "vis" && command.Length > 4)
            {
                var searchId = int.Parse(command.Substring(command.Length - 2));
                foreach (var person in People.Where(person => person.Id == searchId))
                {
                    str += person.GetDescription();
                    childrenSearchId = person.Id;
                }
            }

            str = FindChildren(childrenSearchId, str);
            return str;
        }

        public string FindChildren(int childrenSearchId, string str)
        {
            if (childrenSearchId == 0) return str;
            var count = 0;
            foreach (var person in People.Where(person =>
                person.Father != null && childrenSearchId == person.Father.Id ||
                person.Mother != null && childrenSearchId == person.Mother.Id))
            {
                if (count == 0)
                {
                    str += "\n  Barn:";
                    count++;
                }

                str += $"\n    {person.FirstName} (Id={person.Id}) Født: {person.BirthYear}";
            }

            if (count > 0) str += "\n";
            return str;
        }
    }
}