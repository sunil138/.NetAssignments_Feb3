using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_Feb3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "hello";
            string str1 = "world";
            Console.WriteLine(str.Substring(2));  
            Console.WriteLine(str.CompareTo(str1));
            Console.WriteLine(str.Concat(str1));  
            Console.WriteLine(str.Length);
            Console.WriteLine(str1.Length);
            Console.WriteLine(str.IndexOf("e"));
            Console.WriteLine(str1.LastIndexOf("d")); 
            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str.ToLower());
            Console.WriteLine(str.Trim()); 
            Console.WriteLine(str1.TrimEnd()); 
            Console.WriteLine(str+ " " + str1);
            Console.WriteLine(str.Replace('h', 'e'));
            Console.WriteLine(str.Split()); 


        }
    }
}
