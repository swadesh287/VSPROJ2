using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comments
{
    // compile with: /doc:DocFileName.xml 
    public class TestClass
    {
        /// <summary>DoWork is a method in TestClass  class.
        /// <para>Here's how you could make a second paragraph in a description. <see cref="System.Console.WriteLine(System.String)"/> for information about output statements.</para>
        /// <returns>A <see cref="System.int"/></returns>
        /// <seealso cref="TestClass.Main"/>
        /// 
        /// </summary>
        public static void DoWork(int Int1)
        {
        }

        /// text for Main
        static void Main()
        {
           
        }
        public void tp()
        {
            
        }

        /// <summary>Causes something happen.</summary>
        /// <param name="someValue">A <see cref="String"/>
        ///  type representing some value.</param>
        /// <exception cref="ArgumentNullException">
        ///     if <paramref name="someValue"/> is <c>null</c>.
        /// </exception>
        /// <exception cref="ArgumentException">
        ///     if <paramref name="someValue"/> is <c>empty</c>.
        /// </exception>
        /// <returns><paramref name="someValue"/> as passed in.
        /// </returns>
        public static string MyMethod(string someValue)
        {
            if (null == someValue)
                throw new ArgumentNullException("Your message.");

            if (0 >= someValue.Length)
                throw new ArgumentException("Your message.");

            return someValue;
        }
    }
}
