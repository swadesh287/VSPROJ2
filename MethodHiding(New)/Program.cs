using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding_New_
{
    class Program
    {
        static void Main(string[] args)
        {
            
            A a = new A();
            ((B)a).printIndiB();//RunTime Error
            Console.WriteLine("A-A");
            a.print();
            a.printIndiA();
            a.printLine();
            a.printPlus();
            

            B b = new B();
           // ((A)b).printPlus();
            
            Console.WriteLine("B-B");
            b.print();
            b.printIndiA();
            b.printIndiB();
            b.printLine();
            b.printPlus();
            b.printStar();
            
            
            C c = new C();
            Console.WriteLine("C-C");
            c.print();
            c.printIndiA();
            c.printIndiB();
            c.printIndiC();
            c.printLine();
            c.printPlus();
            c.printStar();
 
            A a1 = new B();
            Console.WriteLine("A-B");
            a1.print();
            a1.print();
            a1.printIndiA();
           // a1.printIndiB(); // This will work using TypeCast
            //Console.WriteLine("In A-B Case Using Base Class Reference Variable we cant access derived Class methods without typecasting. \n eg ((B)a).Methods-Of-B-Class. Output Given Below : ");
            //((B)a1).printIndiB();
           // a1.printIndiC();
           
            //Console.WriteLine("In A-B Case Using Base Class Reference Variable we cant access derived Class methods without typecasting. \n eg ((C)a).Methods-Of-C-Class. Output Given Below : ");
           
            //((C)a1).printIndiC();
            a1.printLine();
            a1.printPlus();
           // a1.printStar();
 

            B b2 = new C();
            Console.WriteLine("B-C");
            b2.print();
            b2.printIndiA();
            b2.printIndiB();
            ((C)b2).printIndiC();
            b2.printLine();
            b2.printPlus();
            b2.printStar();
            
            A a2 = new C();
            Console.WriteLine("A-C");
            a2.print();
            a2.printIndiA();
            ((B)a2).printIndiB();
            //a2.printIndiC();
            a2.printLine();
            a2.printPlus();
            //a2.printStar();
 

            //We Cant Create Base Class Object Using Derived Class Reference Variable. 
            // Example : 
            //1) B b1 = new A();
            //   b1.print();
            //2) C c1 =new B();
            //3) C c1 =new A();

            Console.ReadLine();
        }

    }

    class A
    {
        public void print() { Console.WriteLine("A"); }
        public void printLine() { Console.WriteLine("------Print Line From A(A,C)--------"); }
        public void printPlus() { Console.WriteLine("++++Print Plus From A (A,B) ++++"); }
        public void printIndiA(){Console.WriteLine("Individual A");}
    }

    class B : A
    {
        public void printIndiB(){Console.WriteLine("Individual B");}
        public new void print() { Console.WriteLine("B"); }
        public new void printPlus() { Console.WriteLine("++++Print Plus From B(A,B) ++++"); }

        public void printStar() { Console.WriteLine(" **** Print Star From B (B,C) ****"); }
    }

    class C : B
    {
        public void printIndiC() { Console.WriteLine("Individual C"); }
        public new void print() { Console.WriteLine("C"); }

        public new void printLine() { Console.WriteLine("------Print Line From C(A,C)--------"); }

        public new void printStar() { Console.WriteLine(" **** Print Star From C (B,C)****"); }
    }

    class D
    {
        public void printIndiD() { Console.WriteLine("Individual D"); }
        
    }

}
