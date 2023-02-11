using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorOverloading_Feb3
{
    class Student
    {
        public string name, address;
        public int age;
        public double height;
        public Student(int a, string n)
        {
            age = a;
            name = n;
        }
        public Student(string add,double h,string  n1)
        {
            address = add;
            height = h;
            name = n1;
        }
        public void Print()
        {
            Console.WriteLine("Student Name is: " + name +" and "+"Student age is: " + age);
        }
        public void PrintOne()
        {
            Console.WriteLine("Student name is: " + name + " Student height is: " + height +" feet and "+ "Student address is: " + address);
        }
        static void Main(string[] args)
        {
            Student student = new Student(24,"Lokesh");
            student.Print();
            Student studentOne = new Student("Chennai", 5.8, "Mohan");
            studentOne.PrintOne(); 
        }
    }
}
