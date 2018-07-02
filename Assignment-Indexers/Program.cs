using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            int ch1;
            string ch;
            Company cmp = new Company();

            do
            {
                Console.Clear();
            Console.WriteLine("     Menu    ");
            Console.WriteLine(" 1. Enter New Employee Record. \n 2.Get Employee Details. \n 3. Change Employee Name.");
            ch1=Convert.ToInt16(Console.ReadLine());

            switch (ch1)
            {
                case 1:
                    cmp.SetEmployee();
                    break;
                case 2:
                    GetEmployee(cmp);
                    break;
                case 3:
                    cmp.ChangeName();
                    break;

                default:
                    Console.WriteLine("Please Enter valid Choice.");
                    break;

            }
            Console.WriteLine("Do you want to Continue (y/n)?");
                    ch=Console.ReadLine();
            }
            while(ch.ToUpper()=="Y"||ch.ToUpper()=="Yes");

            Console.ReadLine();
        }
         public static void GetEmployee(Company cmp)
        {
            int id;
            Console.WriteLine("Enter Employee Name/Id :");
            string inputstr=Console.ReadLine();
            if (int.TryParse(inputstr, out id))
            {
                Console.WriteLine(cmp[id]);
            }
            else
            {
                Employee emp1 =cmp[inputstr];
                Console.WriteLine("Id : {0}, Name : {1}, Gender : {2}, City : {3}",emp1._Id,emp1._Name,emp1._Gender,emp1._City);

            }

        }

       

    }   

    class Company
    {
        Employee[] emp = new Employee[10];
        int id;
        public void ChangeName()
        {
            bool flagID = true;
            do
            {

                Console.WriteLine("Enter Employee Id");
                id = Convert.ToInt16(Console.ReadLine());

                foreach (Employee emp1 in emp)
                {
                    if (emp1._Id == id)
                    {
                        Console.WriteLine("Enter New Employee Name (Previous Name : {0} ): ",emp1._Name);
                        emp1._Name = Console.ReadLine();
                        flagID = false;
                        Console.WriteLine("Name Updated Successfully. Id : {0},Name : {1}",emp1._Id,emp1._Name);
                        break;

                    }
                }
            } while (flagID != false);

            if (flagID != false)
            {
                Console.WriteLine("Employee Id Does Not Exist.");
            }

        
        }

        public  void SetEmployee()
        {
            bool flagID = true;
            
            int i=-1;
            try
            {
                do
                {
                    flagID = true;

                    Console.WriteLine("Enter Employee Id");
                    id= Convert.ToInt16(Console.ReadLine());

                    for (i = 0; i < 10;i++ )
                    {
                        if (emp[i] != null && emp[i]._Id == id)
                        {
                            Console.WriteLine("Employee Id Is Not Available.Please Enter Different Employee Id.");
                            flagID = false;
                            break;

                        }
                    }
                } while (flagID == false);

                Console.WriteLine("Enter Employee Name");
                string Name = Console.ReadLine();

                Console.WriteLine("Enter Employee Gender");
                string Gender = Console.ReadLine();

                Console.WriteLine("Enter Employee City");
                string City = Console.ReadLine();

                bool FlagInsert = false;

                for (i = 0; i < 10;i++ )
                {

                    if (emp[i] == null)
                    {
                        emp[i] = new Employee() {_Id=id,_City=City,_Gender=Gender,_Name=Name };
                        
                        FlagInsert = true;
                        break;
                    }
                }
                if (FlagInsert == true)
                {
                    Console.WriteLine("Record Inserted Successfully.");
                }

            }
            catch (Exception ex)
            {
                if (i > 0)
                {
                    emp[i-1] = null;
                }
                Console.WriteLine(ex.Message);
            }
        }
        
        public string this[int Id]
        {
            
            get {
                foreach (Employee emp1 in emp)
                {
                    if (emp1!=null&&emp1._Id.ToString().Length!= 0&&emp1._Id==Id)
                        return emp1._Name;
                }
                return "No Record Found.";
            }

            set {
                bool flag=false;
                foreach (Employee emp1 in emp)
                {
                    if (emp1._Id == Id)
                    {
                        emp1._Name = value;
                        flag = true;
                    }; 
                }
                if (flag == true)
                {
                    Console.WriteLine("Record Updated Successfully.");
                }
                else
                {
                    Console.WriteLine("No Record Found.");
                }
               
            }
        }

        public Employee this[string name]
        {
            get
            {
                foreach(Employee emp1 in emp)
                {

                    if (emp1._Name == name)
                        return emp1;
                }
                return null;
               
            }
        }

    }

    class Employee
    {
        private int? Id=null;
        private string city = null;
        private string name = null;
        private string gender = null;
     
        
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
                    return (name==null||name.ToString()=="")?"No Name":name;
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

        public string _City
        {
            get
            {
                return city;
            }
            set
            {
                if (value.ToString().Length> 4)
                    city = value;
                else
                    Console.WriteLine("Length Of City Must Be Greater Than 4 Character.");
            }
        }
    }
}
