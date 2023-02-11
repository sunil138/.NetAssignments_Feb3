using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorOverloading_Feb3
{
    class Program
    {
        public int number1, number2,number3;
        public Program(int num1, int num2)
        {
            number1 = num1;
            number2 = num2;
        }
        public Program(int num1,int num2,int num3)
        {
            number1 = num1;
            number2 = num2;
            number3 = num3;
        }
        public void Display()
        {
            Console.WriteLine("Addition By 2 Parameters is: " + (number1 + number2)); 
        }
        public void Display1()
        {
            Console.WriteLine("Addition By 3 Parameters is: " + (number1 + number2+number3));
        }

        static void Main(string[] args)
        {
            Program program = new Program(10,40);
            Program programOne = new Program(10, 30, 20);
            program.Display();
            programOne.Display1();  

        }
    }
}
