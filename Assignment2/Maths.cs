using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Maths
    {
        public void add(int a, int b,out int output)
        { 
            output=a+b;
        }
            public void mul(int a, int b,out int output)
        { 
            output=a*b;
        }
        public void sub(int a, int b,out int output)
        { 
            output=a-b;
        }
        public void div(int a, int b,out int output)
        { 
            output=a/b;
        }
        public void rem(int a, int b,out int output)
        { 
            output=a%b;
        }

        public void PrintFibonacciNumber(int num1)
        {
            long[] fibseries=new long[num1];
            fibseries[0]=0;
            fibseries[1]=1;
            string str = "0,1,";
            for (int i = 2; i <= num1-1; i++)
            {
                fibseries[i] = fibseries[i - 1] + fibseries[i - 2];
                str = str + fibseries[i].ToString() + ",";
            }
            Console.WriteLine("First {0} Fibonacci Series Numbers Are : {1} .", num1,str.Remove(str.Length-1)); 
            
        }

        public bool checkPrime(int a)
        {

            int count = 0;
            for (int i = 1; i <= a; i++)
            {

                if (a % i == 0)
                {
                    count++;
                }
                
            }

            if (count == 2)
                return true;
            else
                return false;
        }


        public string listPrime(int a)
        {

            string primes = string.Empty;
            int count = 0;
            
            for (int i = 1; i <= a; i++)
            {
                count = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                      if (count == 2)
                      {
                        primes=primes+Convert.ToString(i)+",";
                      }
            }

          if(primes==string.Empty)
              return "No prime Number Found Upto " + Convert.ToString(a)+".";
           else
              return "Prime Numbers Upto " + Convert.ToString(a)+" are : "+primes.Remove(primes.Length-1)+".";
        }

        public void CheckForPalindrome(int num1)
        {
            if (Convert.ToInt32(ReverseStr(num1.ToString()))== num1)
            {
                Console.WriteLine("{0} Is Palindrome Number.", num1);
            }
            else {
                Console.WriteLine("{0} Is Not Palindrome Number.", num1);
            
            }
        }


        public void CheckForArmstrong(int num1)
        {
            int len=num1.ToString().Length;
            long powerNum1=0;
            string strnum1=num1.ToString();
            //long[] num1Power = new long[num1];
            Console.WriteLine(len);
            for (int i = 0; i <=len-1 ; i++)
            {
                int num2 = Convert.ToInt32(strnum1[i].ToString());
                powerNum1 = powerNum1 + PowerNum(num2, len);
            }

            if (powerNum1 == num1)
                Console.WriteLine("{0} Is Armstrong Number.",num1);
            else
                Console.WriteLine("{0} Is Not Armstrong Number.", num1);
        }


        public long PowerNum(int num,int power)
        {
            long powNum=num;
            if(power==0)
            return 1;
            if(power==1)
            return num;

            for (int i = 2; i <= power; i++)
            {
                powNum = powNum * num;
            }
            return powNum;
        }

        public int[] ReverseArr(int[] Arr1) 
        {
            int temp;
            int ArrLastIndex=Arr1.Length - 1;
            for (int i = 0; i <= ArrLastIndex/2 ; i++)
            {
                temp = Arr1[i];
                Arr1[i] = Arr1[ArrLastIndex - i];
                Arr1[ArrLastIndex - i] = temp;
                
            }

            return Arr1;
        }
        public string ReverseStr(string str)
        { 
        
            string revStr=string.Empty;

            for (int i = str.Length - 1; i >= 0;i--)
            {
                revStr = revStr + str[i];
            }
            return revStr;

        }


        
    }
}
