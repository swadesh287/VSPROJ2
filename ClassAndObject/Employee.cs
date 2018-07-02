using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    class Employee
    {
        public string FirstName;
        public string LastName;

        static int workinghours = 8;

        static Employee()
        {
            Console.WriteLine("Working Hours Of All Employees Is : {0}", workinghours);
        }
        //public Employee()
        //{
        //   // Console.WriteLine("Working Hours Of All Employees Is : {0}", workinghours);
        //}
        public Employee(int i)
        {
            Console.WriteLine("Working Hours Of Current Employee Is : {0}", workinghours + i);
        }
        //public Employee(int extrawrkhr)
        //{
        //    Console.WriteLine("Working Hours Of Current Employee Is : {0}", workinghours + extrawrkhr);
        //}
        
        public void PrintFullName()
        {
            Console.WriteLine("Full Name Is : {0} {1}",FirstName,LastName);
        }
    }
}
