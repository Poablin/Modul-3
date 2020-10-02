using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro
{
    class Converting
    {
        static void Something()
        {
            // to string
            var x = true;
            double d = 99.123;
            string s = "" + x;
            //to int
            int i = Convert.ToInt32(d);
        }
    }
}
