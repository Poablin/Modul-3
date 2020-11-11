using System;
using System.Collections.Generic;

namespace DictionaryClassTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> testDictionary = new Dictionary<string, string>();
            testDictionary.Add("tst", "Heijegerentestdictionary");
            testDictionary.Add("jada", "tssssssssssssssssssssssssssssssst");
            Console.WriteLine(testDictionary["tst"]);
            Console.WriteLine(testDictionary["jada"]);

            // Tester KeyNotFoundException
            try
            {
                Console.WriteLine(testDictionary["yes"]);
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("KeyNotFoundException fordi yes keyen ikke finnes");
            }

        }
    }
}
