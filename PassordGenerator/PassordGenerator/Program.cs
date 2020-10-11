using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!IsValid(args))
            {
                ShowHelpMessage();
                return;
            }

            string pattern = args[1];
            Console.WriteLine(pattern.PadRight(Convert.ToInt32(args[0]), 'l'));
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
                    if (c != 'L' && c != 'd' && c != 's')
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
