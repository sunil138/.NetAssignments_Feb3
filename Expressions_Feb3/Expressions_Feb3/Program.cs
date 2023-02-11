using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expressions_Feb3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1=15, num2=26, sum;
            sum = num1 +num2;
            Console.WriteLine("Addition of 2 Numbers is: "+sum);

            float f = 6.4f;
            Console.WriteLine("Floating point number is: "+f);

            bool b1 = true;
            bool b2 = false;
            Console.WriteLine(b1&&b2); 

            int age = 26;
            if(age<18)
            {
                Console.WriteLine("Not eligible to Vote");
            }
            else
            {
                Console.WriteLine(age + " Years is Eligible to Vote"); 
            }

            double d = 45.9873;
            Console.WriteLine(d); 
        }
    }
}
