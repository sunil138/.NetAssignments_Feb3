using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorOverloading_Feb3
{
    class Car
    {
        public int price;
        public string name;
        public Car()
        {
            Console.WriteLine("A default Constuctor with 0 arguments");
        }
        public Car(string n, int p)
        {
            name = n;
            price = p;
        }
        public void Show()
        {
            Console.WriteLine("Car Name is: " + name);
            Console.WriteLine("Car color is: " + price);
        }
        static void Main(string[] args)
        {
            Car car = new Car();
            Car carOne = new Car("Tesla", 7000000);
            carOne.Show(); 
        }
    }
}
