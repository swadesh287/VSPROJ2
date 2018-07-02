using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_OverRidingAndOverLoading_
{
    class Program
    {
        static void Main(string[] args)
        {

            A a = new A();
            int b = 0;
            C c = new C();
            
            c.print(b);
             
            try
            {
                Console.WriteLine(Convert.ToByte(Marshal.SizeOf(a))/b);// To calculate or check the size of unmannaged memmory.
            }
            catch (Exception ex)
            {
                
               // return;
            }
            finally
                {
                Console.WriteLine("finally");
               // return;
            }
            Console.ReadLine();
        }

    }
    
    [StructLayout(LayoutKind.Sequential)] // To calculate or check the size of unmannaged memmory.
    class A 
    {
        /// <summary>
        ///  integer value for age;
        /// </summary>
        public int a=10;
        public double b = 10.00;
        
      
    }
    class B:A
    {
        public new double a = 10;

    }
    class C : B 
    {
        public new decimal a = 10m;
      
        /// <summary>
        ///    this method is use to print.
        /// </summary>
        /// <param name="m">value to print</param>
        ///  <exception cref="DivideByZeroExp">this Will Throw Divide by Zero Exception</exception>
        public void print(int m) { Console.WriteLine("B"+m.ToString()); }
        
    }

}
