using System;
using System.Linq;
using System.Text;

namespace Oblig1
{
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
            string str = "";
            str += FirstName != null ? FirstName + " " : "";
            str += LastName != null ? LastName + " " : "";
            str += Id != 0 ? $"(Id={Id}) " : "";
            str += BirthYear != 0 ? $"Født: {BirthYear} " : "";
            str += DeathYear != 0 ? $"Død: {DeathYear} " : "";
            str += Father != null ? $"Far: {Father.FirstName} (Id={Father.Id}) " : "";
            str += Mother != null ? $"Mor: {Mother.FirstName} (Id={Mother.Id}) " : "";
            return str.Trim();
        }
    }
}