using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            int num1;
            int num2;
            string ch=string.Empty;
            try
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("--------MENU--------");
                    Console.WriteLine(" 1.Addition \n 2.Substraction \n 3.Multiplication \n 4.Division \n 5.Reminder");
                    Console.WriteLine(" 6.Print Fibonacci Series \n 7.Check For Prime Number \n 8.Print Prime Number Upto n");
                    Console.WriteLine(" 9.Print Palindrome \n 10.Print Armstrong");
                    Console.WriteLine(" 11.Reverse String \n 12.Reverse Array");
                    Console.WriteLine("Enter Your Choice : ");
                    Maths maths1 = new Maths();

                    choice = Convert.ToInt32(Console.ReadLine());



                    switch (choice)
                    {
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                            {
                                Console.WriteLine("Enter First Number :");
                                num1 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter Second Number :");
                                num2 = Convert.ToInt32(Console.ReadLine());
                                int output = 0;
                                switch (choice)
                                {
                                    case 1:
                                        maths1.add(num1, num2, out output);
                                        break;
                                    case 2:
                                        maths1.sub(num1, num2, out output);
                                        break;
                                    case 3:
                                        maths1.mul(num1, num2, out output);
                                        break;
                                    case 4:
                                        maths1.div(num1, num2, out output);
                                        break;
                                    case 5:
                                        maths1.rem(num1, num2, out output);
                                        break;

                                }
                                Console.WriteLine("Answer : " + output);
                                break;
                            }
                        case 6:

                            Console.WriteLine("Enter Number : ");
                            num1 = Convert.ToInt32(Console.ReadLine());

                            maths1.PrintFibonacciNumber(num1);

                            break;
                        case 7:
                            Console.WriteLine("Enter Number : ");
                            num1 = Convert.ToInt32(Console.ReadLine());

                            if (maths1.checkPrime(num1))
                                Console.WriteLine(num1.ToString() + " Is Prime Number.");
                            else
                                Console.WriteLine(num1.ToString() + " Is Not Prime Number.");

                            break;

                        case 8:
                            Console.WriteLine("Enter Number : ");
                            num1 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine(maths1.listPrime(num1));

                            break;
                       
                        case 9:
                            Console.WriteLine("Enter Number : ");
                            num1 = Convert.ToInt32(Console.ReadLine());
                            
                            maths1.CheckForPalindrome(num1);
                            break;
                        case 10:
                            Console.WriteLine("Enter Number : ");
                            num1 = Convert.ToInt32(Console.ReadLine());

                            maths1.CheckForArmstrong(num1);
                            break;
                        case 11:
                            
                            Console.WriteLine(choice);
                            break;
                        case 12:
                            Console.WriteLine("Enter Size Of Array :");
                            short n =Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine("Enter {0} Array Elements (Using Comma/Space): ",n);
                           string str1= Console.ReadLine();
                           int[] Arr1 =new int[n];
                            Arr1=str1.Split(new char[]{',',' '}).Select(s=>Convert.ToInt32(s)).ToArray();
                            Arr1=maths1.ReverseArr(Arr1);
                            Console.WriteLine("Reverse Array Is : {0}",string.Join(", ",Arr1));
                           
                            break;
                        default:
                            break;
                    }
                    Console.WriteLine("Do You Want To Continue ?");
                    ch = Console.ReadLine();
                }
                while (ch.ToLower() == "y" || ch.ToLower() == "yes");

                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
        }
    }
}
