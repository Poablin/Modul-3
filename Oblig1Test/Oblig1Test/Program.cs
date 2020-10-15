using System;

namespace Oblig1Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var sverreMagnus = new Person { Id = 1, FirstName = "Sverre Magnus", BirthYear = 2005 };
            var ingridAlexandra = new Person { Id = 2, FirstName = "Ingrid Alexandra", BirthYear = 2004 };
            var haakon = new Person { Id = 3, FirstName = "Haakon Magnus", BirthYear = 1973 };
            var metteMarit = new Person { Id = 4, FirstName = "Mette-Marit", BirthYear = 1973 };
            var marius = new Person { Id = 5, FirstName = "Marius", LastName = "Borg Høiby", BirthYear = 1997 };
            var harald = new Person { Id = 6, FirstName = "Harald", BirthYear = 1937 };
            var sonja = new Person { Id = 7, FirstName = "Sonja", BirthYear = 1937 };
            var olav = new Person { Id = 8, FirstName = "Olav", BirthYear = 1903 };

            sverreMagnus.Father = haakon;
            sverreMagnus.Mother = metteMarit;
            ingridAlexandra.Father = haakon;
            ingridAlexandra.Mother = metteMarit;
            marius.Mother = metteMarit;
            haakon.Father = harald;
            haakon.Mother = sonja;
            harald.Father = olav;

            var app = new FamilyApp(sverreMagnus, ingridAlexandra, haakon,
                metteMarit, marius, harald, sonja, olav);
            Console.WriteLine(app.WelcomeMessage);
            //while (true)
            //{
            //    Console.Write(app.CommandPrompt);
            //    var command = Console.ReadLine();
            //    var response = app.HandleCommand(command);
            //    Console.WriteLine(response);
            //}
        }
        }

    internal class FamilyApp
    {
        internal string WelcomeMessage = @"hjelp => viser en hjelpetekst som forklarer alle kommandoene
liste => lister alle personer med id, fornavn, fødselsår, dødsår og navn og id på mor og far om det finnes registrert.
vis<id> => viser en bestemt person med mor, far og barn(og id for disse, slik at man lett kan vise en av dem)";
        private Person sverreMagnus;
        private Person ingridAlexandra;
        private Person haakon;
        private Person metteMarit;
        private Person marius;
        private Person harald;
        private Person sonja;
        private Person olav;

        public FamilyApp(Person sverreMagnus, Person ingridAlexandra, Person haakon, Person metteMarit, Person marius, Person harald, Person sonja, Person olav)
        {
            this.sverreMagnus = sverreMagnus;
            this.ingridAlexandra = ingridAlexandra;
            this.haakon = haakon;
            this.metteMarit = metteMarit;
            this.marius = marius;
            this.harald = harald;
            this.sonja = sonja;
            this.olav = olav;
        }
    }
    public class Person
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public int DeathYear { get; set; }
        public Person Father { get; set; }
        public Person Mother { get; set; }

        public string GetDescription()
        {
            if (FirstName == null || LastName == null || BirthYear == 0 || DeathYear == 0 || Father == null || Mother == null)
            {
                return CheckWhichEmptyField();
            }
            
            return $"{FirstName} {LastName} (Id={Id}) Født: {BirthYear} Død: {DeathYear} Far: {Father.FirstName} (Id={Father.Id}) Mor: {Mother.FirstName} (Id={Mother.Id})";
        }

        private string CheckWhichEmptyField()
        {

            string str = "";
            if (FirstName != null)
            {
                str += $"{FirstName} ";
            }
            if (LastName != null)
            {
                str += $"{LastName} ";
            }
            if (Id != 0)
            {
                str += $"(Id={Id}) ";
            }
            if (BirthYear != 0)
            {
                str += $"Født: {BirthYear} ";
            }
            if (DeathYear != 0)
            {
                str += $"Død: {DeathYear} ";
            }
            if (Father != null)
            {
                str += $"Far: {Father.FirstName} (Id={Father.Id}) ";
            }
            if (Mother != null)
            {
                str += $"(Mor: {Mother.FirstName} (Id={Mother.Id})";
            }

            return str;
        }
    }
}

