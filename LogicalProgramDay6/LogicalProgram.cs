using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LogicalProgramDay6
{
    public class LogicalProgram
    {
        public  void FibonacciSeries()
        {
            Console.WriteLine("Enter number");
            int count = Convert.ToInt32(Console.ReadLine());
            int num1 = 0, num2 = 1, num3;
            for (int i = 2; i < count; i++)
            {
                num3 = num1 + num2;
                Console.WriteLine(num3);
                num1 = num2;
                num2 = num3;
            }
        }

        public void Palindrome()
        {
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int rem, rev = 0, temp;
            temp = num;
            while (num > 0)
            {
                rem = num % 10;
                rev = (rev * 10) + rem;
                num /= 10;
            }
            if (temp == rev)
            {
                Console.WriteLine("is a palindrome number");
            }
            else
            {
                Console.WriteLine("is not a palindrome number");
            }
        }

        public void PerfectNum()
        {
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0, temp;
            temp = num;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (temp == sum)
            {
                Console.WriteLine("is a perfect number");
            }
            else
            {
                Console.WriteLine("is not a perfect number");
            }
        }

        public void ReverseString()
        {
            Console.WriteLine("Enter Number");
            string str =Convert.ToString(Console.ReadLine());
            string rev = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev = rev + str[i];
            }
            Console.WriteLine("Reverse String are " + rev);
        }

        public void ReverseNumber()
        {
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int rem = 0, rev = 0;    
            while (num != 0)
            {
                rem = num % 10;
                rev = (rev * 10) + rem;
                num /= 10;
            }
            Console.WriteLine("Reverse Number is : "+ rev);
        }
        public void CouponNumber()
        {
            char[] ch = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToCharArray();
            char[] stringChar = new char[10];
            Random random = new Random();

            for(int i = 0; i < stringChar.Length; i++)
            {
                stringChar[i] = ch[random.Next(ch.Length)];
            }
            string coupon = new string(stringChar);
            Console.WriteLine("coupon is generated : " + coupon);
        }

        public void StopWatchProgram()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("hii");
            }
            sw.Stop();
            Console.WriteLine("Time elapsed : {0} ",sw.Elapsed);
        }
    }
}
