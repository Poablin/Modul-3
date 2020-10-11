using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PassordGenerator
{
    class Program
    {
        static readonly Random Random = new Random();
        static void Main(string[] args)
        {
            if (!IsValid(args))
            {
                ShowHelpMessage();
                return;
            }

            int length = Convert.ToInt32(args[0]);
            string options = args[1]; 
            string pattern = options.PadRight(length, 'l');
            Console.WriteLine("Pattern er: " + pattern);

            string output = "";
            while (pattern.Length > 0)
            {
                string s = pattern.Substring(pattern.Length - 1);
                if (s == "l") output += WriteRandomLowerCaseLetter();
                if (s == "L") output += WriteRandomUpperCaseLetter();
                if (s == "d") output += WriteRandomDigit();
                if (s == "s") output += WriteRandomSpecialCharacter();
                pattern = pattern.Remove(pattern.Length - 1);
            }
            
            Console.WriteLine("output er: " + output);
            // Er på punkt 6 i oppgaven
        }

        private static char WriteRandomLowerCaseLetter()
        {
            return GetRandomLetter('a', 'z');
        }

        private static char WriteRandomUpperCaseLetter()
        {
            return GetRandomLetter('A', 'Z');
        }

        private static char WriteRandomDigit()
        {
            return Random.Next(0, 9).ToString()[0];
        }

        private static char WriteRandomSpecialCharacter()
        {
            var specialCharacters = "!\"#¤%&/(){}[]";
            var index = Random.Next(0, specialCharacters.Length - 1);
            return specialCharacters[index];
        }

        static char GetRandomLetter(char min, char max)
        {
            return (char)Random.Next(min, max);
        }

        private static bool IsValid(string[] args)
        {
            if (args.Length <= 0)
            {
                return false;
            }

            if (args.Length == 2)
            {
                string s1 = args[0];
                string s2 = args[1];
                foreach (var c in s1)
                {
                    if (char.IsDigit(c) == false)
                    {
                        return false;
                    }
                }

                foreach (var c in s2)
                {
                    if (c != 'l' && c != 'L' && c != 'd' && c != 's')
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private static void ShowHelpMessage()
        {
            string startMessage =
                @"PasswordGenerator  
  Options:
  - l = lower case letter
  - L = upper case letter
  - d = digit
  - s = special character (!""#¤%&/(){}[]
Example: PasswordGenerator 14 lLssdd
         Min. 1 lower case
         Min. 1 upper case
         Min. 2 special characters
         Min. 2 digits";
            Console.WriteLine(startMessage);
        }
    }
}
