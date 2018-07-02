using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee emp1 = new Employee(1);
            //emp1.FirstName = "Swapnil";
            //emp1.LastName = "Deshmukh";
            //emp1.PrintFullName();

            //Employee emp2 = new Employee(2);
            //emp2.FirstName = "Ashish";
            //emp2.LastName = "Deshmukh";

           // emp2.PrintFullName();

            int result ;
            result= 0; 
            ByRef(10,20,ref result);
            Console.WriteLine(result);
            
            Console.ReadLine();
        }

        public static void  ByRef(int b,int a,ref int result)
         {
            result=a+b;
//return a;
        }

    }
}
