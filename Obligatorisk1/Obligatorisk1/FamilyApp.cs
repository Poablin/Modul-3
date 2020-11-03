using System.Collections.Generic;
using System.Linq;

namespace Oblig1
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
            int childrenSearchId = 0;
            string str = "";
            if (command == "hjelp") str += "\nhjelp => viser en hjelpetekst som forklarer alle kommandoenliste\n" +
                                           "liste => lister alle personer med id, fornavn, fødselsår, dødsår og navn og id på mor og far om det finnes registrert.\n" +
                                           "vis <id> => viser en bestemt person med mor, far og barn(og id for disse, slik at man lett kan vise en av dem)\n";
            if (command == "liste") str = People.Aggregate(str, (current, person) => current + (person.GetDescription() + "\n"));
            if (command.Substring(0, 3) == "vis" && command.Length > 4)
            {
                int searchId = int.Parse(command.Substring(command.Length - 2));
                foreach (var person in People.Where(person => person.Id == searchId))
                {
                    str += person.GetDescription();
                    childrenSearchId = person.Id;
                }
            }

            str = FindChildren(childrenSearchId, str);
            return str;
        }

        private string FindChildren(int searchForChildrenId, string str)
        {
            if (searchForChildrenId == 0) return str;
            int count = 0;
            foreach (var person in People.Where(person => person.Father != null && searchForChildrenId == person.Father.Id || person.Mother != null && searchForChildrenId == person.Mother.Id))
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