using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETTraining
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("ENTER THE NUMBER");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = a;
            int rev = 0;
            int remainder = 0;
            int sum = 0;
            while(b!=0)
           {
               remainder = b % 10;
               rev = rev * 10 + remainder;
               b = b / 10;
           }
           Console.WriteLine(rev);
            
            
            while(a!=0)
            {
                remainder= a % 10;
                sum = sum + remainder;
                a = a / 10;
            }
            Console.WriteLine(sum);
        }
    }
}
