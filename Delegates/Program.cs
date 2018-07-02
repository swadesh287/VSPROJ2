using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Delegates
{
  

        class PrintString
        {
            static FileStream fs;
            static StreamWriter sw;

            // delegate declaration
            public delegate void printString(string s);

            // this method prints to the console
             public static void WriteToScreen(string str)
            {
                string str3 = "The String is: {0}";
                Console.WriteLine(str3);
                
                 Console.WriteLine(ConfigurationSettings.AppSettings.GetValues("str2").ToString(), str);
            }

            //this method prints to a file
            public static void WriteToFile(string s)
            {
                fs = new FileStream("c:\\message.txt",
                FileMode.Append, FileAccess.Write);
                sw = new StreamWriter(fs);
                sw.WriteLine(s);
                sw.Flush();
                sw.Close();
                fs.Close();
            }

            // this method takes the delegate as parameter and uses it to
            // call the methods as required
            public static void sendString(printString ps)
            {
                ps("Hello World");
            }

            static void Main()
            {
                printString ps1 = new printString(WriteToScreen);
                printString ps2 = new printString(WriteToFile);
               // sendString(ps1);
                //sendString(ps2);
                printString ps3 = ps1;
                ps3 += ps2;
                sendString(ps3);
                Console.ReadKey();
            }
        }
    
}
