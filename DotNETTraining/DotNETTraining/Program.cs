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
            int a = 123;
            int rev = 0;
            int remainder;
            int sum=0;
           while(a!=0)
           {
               remainder = a % 10;
               rev = rev * 10 + remainder;
               a = a / 10;
           }
            while(a!=0)
            {
                remainder= a % 10;
                sum = sum + remainder;
                a = a / 10;
            }
        }
    }
}
