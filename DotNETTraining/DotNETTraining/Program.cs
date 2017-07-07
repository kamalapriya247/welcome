using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DotNETTraining
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value:");
            int number = Convert.ToInt32(Console.ReadLine());
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Reverse(number));
            Console.WriteLine(calculator.Addition(number));
        }
    }
}
