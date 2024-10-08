using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8_OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car car1 = new Car("Tessla", "Electronic", 4570, 2023, 30000, "White");
            Console.WriteLine(car1.ToString());

        }
    }


    class Car
    {
        string model { get; set; }
        string type { get; set; }
        int palletNum { get; set; }
        int yearMaking { get; set; }
        double price { get; set; }
        string color { get; set; }

        public Car(string mdl,string typ, int pallNum, int yearMake, double prc, string clr)
        {
            model = mdl;
            type = typ;
            palletNum = pallNum;
            yearMaking = yearMake;
            price = prc;
            color = clr;
        }

        public void startEngine()
        {
            Console.WriteLine("Engine has been started!");
        }

        public void stropEngine()
        {
            Console.WriteLine("Engine has been stopped!");
        }

        public override string ToString()
        {


            return $"{model} Model \n{type} Type \nCreated in {yearMaking} \nWith a color of {color} \nPallet no. {palletNum} \nwtih a price of $ {price}";
        }

    }
}
