using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters")]
    class Class1
    {
        public static void WriteToScreen(string str)
        {
            //Console.WriteLine("The String is: {0}", str);

            Console.WriteLine("Print");

        }

        public static void WriteToScreen2(string str)
        {
            //Console.WriteLine("The String is: {0}", str);
            Console.WriteLine("Print2");
        }

    }
}
