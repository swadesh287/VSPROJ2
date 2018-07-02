using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList CustList = new ArrayList();
            Customer A = new Customer() { _Id = 1, _Name = "Swap", _Gender = "Male" };
            Customer B = new Customer() { _Id = 2, _Name = "Sup", _Gender = "Female" };
            Customer C = new Customer() { _Id = 3, _Name = "Ash", _Gender = "Male" };
            CustList.Add(A);
            
            ICollection IC = new ArrayList() { B, C };
            CustList.AddRange(IC);
            Console.WriteLine("Using ArrayList : ");
            foreach (Customer cust in CustList)
            {
                Console.WriteLine("ID :{0} ;Name :{1} ;Gender :{2} ", cust._Id, cust._Name, cust._Gender);
            }

            Hashtable custHt = new Hashtable();
            custHt.Add(A._Id, A._Name);
            custHt.Add(B._Id, B._Name);
            custHt.Add(C._Id, C._Name);

            Console.WriteLine("--------------------------------------------------------------");

            Console.WriteLine("Using HashTable : ");
            foreach (DictionaryEntry cust in custHt)
            {
                Console.WriteLine("ID :  {0};Name : {1}",cust.Key,cust.Value);
            }

            Console.WriteLine("Using HashTable By passing key as Index) : ");
            Console.WriteLine(custHt[1]);

            Console.WriteLine("--------------------------------------------------------------");

            Stack CustStack = new Stack();
            CustStack.Push(A);
            CustStack.Push(C);
            CustStack.Push(B);

            Console.WriteLine("Using Stack : ");
            //foreach (dynamic cust in CustStack)
            //{
            //    Console.WriteLine(cust[cust]);
            //}
            Console.WriteLine(((Customer)(CustStack.Pop()))[((Customer)(CustStack.Pop()))]);

            Console.ReadLine();


        }
    }
    class Customer
    {
       
        private int? Id =null;
        private string name = null;
        private string gender = null;

        public string this[Customer cust]
        {
            get
            {
                Console.WriteLine("ID :{0} ;Name :{1} ;Gender :{2} ", cust._Id, cust._Name, cust._Gender);
            return "" ;
            }
        }

        public int? _Id
        {
            get
            {
                return Id;
            }
            set
            {
                if (value > 0)
                    Id = value;

            }
        }

        public string _Name
        {
            get
            {
                return (name == null || name.ToString() == "") ? "No Name" : name;
            }
            set
            {

                name = value;
            }
        }

        public string _Gender
        {
            get
            {

                return gender;
            }
            set
            {
                if ((value.ToString().ToUpper() == "MALE" || value.ToString().ToUpper() == "FEMALE"))
                    gender = value;
                else
                    Console.WriteLine("Gender Must Be Male OR Female.");
            }
        }


    }

}
