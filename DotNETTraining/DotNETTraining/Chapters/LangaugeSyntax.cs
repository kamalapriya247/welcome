using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETTraining.Chapters
{
    class LangaugeSyntax
    {
        static void main()
        {
           
            //boxing

            int num = 10;
            object obj = (object)num;

            //unboxing

            int i = (int)obj;
            byte b = 1;

            //implicit casting- type safe

            b++;

            //explicit casting- it requires cast operator

            b = (byte)(b + 1);

            //pass by value

            int value1 = 0;
            Myfunc(value1);
            Console.WriteLine(value1); 

            //pass by reference

            int value2 = 0;
            Myfunc1(ref value2);
            Console.WriteLine(value2);

            //output parameters

            int add1, prod1;
            Myfunc2(2,3,out add1,out prod1);
            Console.WriteLine("sum:"+ add1 + "prod:" + prod1);

           
        }
        //call by value

        public static void Myfunc(int value3)
        {
            value3 = 10;
        }
        //call by reference

        public static void Myfunc1(ref int value4)
        {
            value4 = 10;
        }
        //using out parameters

        public static void Myfunc2(int x, int y, out int add ,out int prod )
        {
            add= x+y;
            prod=x*y;
        }
    
     
    }
    }


