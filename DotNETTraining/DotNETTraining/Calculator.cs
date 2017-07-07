using DotNETTraining.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETTraining
{
    class Calculator : ICalculator
    {
        public int Reverse(int number)
        {
            int reverse = 0, remainder;
            while (number != 0)
            {
                remainder = number % 10;
                reverse = reverse * 10 + remainder;
                number = number / 10;
            }
            return reverse;
        }

        public int Addition(int number)
        {
            int remainder, sum = 0;
            while (number != 0)
            {
                remainder = number % 10;
                sum = sum + remainder;
                number = number / 10;
            }
            return sum;
        }
    }
}
