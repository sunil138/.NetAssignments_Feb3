using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder_Feb3
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Sunil");
            sb.Append(", Yaswanth");
            sb.Append(", Bangalore");
            sb.Append(", India");
            Console.WriteLine(sb);

            StringBuilder sbOne = new StringBuilder("Total amount is");
            int price = 150; 
            sbOne.AppendFormat(" {0:c}", price);        
            Console.WriteLine(sbOne);

            StringBuilder sbTwo = new StringBuilder("Welcome C#");
            sbTwo.Insert(8, "To ");  
            Console.WriteLine(sbTwo);

            sbTwo.Replace("C#", ".net");
            Console.WriteLine(sbTwo);

            sbTwo.Remove(8, 7); 
            Console.WriteLine(sbTwo);   
            
        }
    }
}
