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
            if (args.Length <= 0)
            {
                Console.WriteLine(startMessage);
            }

            if (args.Length == 2)
            {

            }
        }
    }
}
