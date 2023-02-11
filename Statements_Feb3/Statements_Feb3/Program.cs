using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statements_Feb3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Student marks:");
            int marks = Convert.ToInt32(Console.ReadLine());
            if(marks<35)
            {
                Console.WriteLine("Student failed in the exam");
            }
            else
            {
                Console.WriteLine("Student passed in the exam");  
            }

            Console.WriteLine("Enter the day:");
            int day = Convert.ToInt32(Console.ReadLine());
            switch (day) 
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday"); 
                    break;
                default:
                    Console.WriteLine("Input is wrong");
                    break; 
            }

            for(int i=0;i<10;i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            int j = 0;
            while(j<10)
            {
                j++; 
                if (j==5)
                {
                    continue;        
                }
                Console.Write(j+" "); 
            }
            Console.WriteLine(); 

            int m = 56 / 3;  
            try
            { 
                Console.WriteLine(m);
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception is handled "+e);
            }

        }
    }
}
