using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace KeyWordsandIdentifiers_Feb3 
{
    class One
    {
        public int m;
    }
    class Two
    {
        public static int value = 58;
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            Console.WriteLine("The Number is: " + a);

            float f = 6.8f;
            Console.WriteLine("The floating point number is: " + f);

            bool b = false;
            Console.WriteLine(b);

            One one = new One();
            one.m = 50;
            Console.WriteLine(one.m);

            byte c = 255;
            Console.WriteLine(c);

            for (int i = 0; i < 5; i++)
            {
                if (i == 3)
                    break;
                Console.Write(i + " ");
            }
            Console.WriteLine();

            int @int = 14;
            Console.WriteLine(@int);

            double d = 23.778;
            Console.WriteLine(d);

            char ch = 'a';
            Console.WriteLine(ch);

            Console.WriteLine(Two.value);
        }
    }
}
