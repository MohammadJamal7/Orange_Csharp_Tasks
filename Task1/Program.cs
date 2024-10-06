using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task2
            //arrayManipulating();

            //Task3
            //personData();

            //Task4
            // arrInput();

            //Task5
            arrSumm();

        }


        void vars()
        {
            int integer = 1;
            double dob = 1.3;
            float fl = 2.3f;
            short sh = 0;
            string str = "This a string";
            bool b = false;
            const int nonChangeableevalue = 1;
        }
        static void arrayManipulating()
        {
            string[] cars = { "Ford", "BMW", "Mercedes" };

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            Console.WriteLine(cars.Length);

        }

        static void personData()
        {
            string fname = Console.ReadLine();
            string lname = Console.ReadLine();
            int birthDate = int.Parse(Console.ReadLine());

            Console.WriteLine(fname + " " + lname + " " + birthDate);
        }


        static void arrInput()
        {
            int[] arr = new int[10];
            string elements = "";

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter an element:");
                string el = Console.ReadLine();
                arr[i] = Convert.ToInt16(el);
                elements += " " + arr[i].ToString();
            }

            Console.WriteLine(elements);


        }

        static void arrSumm()
        {
            string[] arr = new string[10];
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter an alement");

                int el = int.Parse(Console.ReadLine());
                sum += el;

            }
            Console.WriteLine("The sum is:" + sum);

        }

    }
}
