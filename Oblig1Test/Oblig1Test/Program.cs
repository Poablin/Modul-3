using System;

namespace Oblig1Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person
            {
                Id = 17,
                FirstName = "Ola",
                LastName = "Nordmann",
                BirthYear = 2000,
                DeathYear = 3000,
                Father = new Person() {Id = 23, FirstName = "Per"},
                Mother = new Person() {Id = 29, FirstName = "Lise"},
            };

            Console.WriteLine(p.GetDescription());
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
            if (FirstName != string.Empty) 
            {
                
            }
            return $"{FirstName} {LastName} (Id={Id}) Født: {BirthYear} Død: {DeathYear} Far: {Father.FirstName} (Id={Father.Id}) Mor: {Mother.FirstName} (Id={Mother.Id})";
        }
    }
}
