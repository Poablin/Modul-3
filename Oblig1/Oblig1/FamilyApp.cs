namespace Oblig1
{
    internal class FamilyApp
    {
        private Person sverreMagnus;
        private Person ingridAlexandra;
        private Person haakon;
        private Person metteMarit;
        private Person marius;
        private Person harald;
        private Person sonja;
        private Person olav;

        public string WelcomeMessage = @"
hjelp => viser en hjelpetekst som forklarer alle kommandoene
liste => lister alle personer med id, fornavn, fødselsår, dødsår og navn og id på mor og far om det finnes registrert. 
vis <id> => viser en bestemt person med mor, far og barn (og id for disse, slik at man lett kan vise en av dem)";

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
}