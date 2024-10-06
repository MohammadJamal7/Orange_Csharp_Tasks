using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Topics3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
             
            //q1();
            //q2();
            //q3();
            //q4();
            //q5();
            //q6();
            //q7();
            //q8();
            //q9("first ssff");
        }

        static void q1()
        {
            Console.WriteLine("Enter two numbers");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("The sum equals:" + (num1 + num2));

        }

        static void q2()
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(num < 0 ? "The sign is: -" : "The sign is: +");
        }

        static void q3()
        {
            List<int> numbers = new List<int>();

            while (true)
            {
                Console.WriteLine("Enter number:");
                int num = int.Parse(Console.ReadLine());
                if (num != -1)
                {
                    numbers.Add(num);
                }
                else { break; }

            }
            numbers.Sort();
            numbers.Reverse();
            Console.WriteLine("The sorted numbers reversely:");
            foreach (var item in numbers)
            {

                Console.WriteLine(item);
            }


        }


        static void q4()
        {
            int[] nums = { 1, 4, 6, 8, 3 };
            int max = nums.Max();
            Console.WriteLine(max);
        }

        static void q5()
        {

            double numInkm = double.Parse(Console.ReadLine());
            Console.WriteLine(numInkm * 1.6);

        }

        static void q6()
        {

            Console.WriteLine("Enter hours");
            double hours = double.Parse(Console.ReadLine());
            double minutes = double.Parse(Console.ReadLine());
            Console.WriteLine("Total number in minutes:" + (hours * 60 + minutes));
        }

        static void q7()
        {

            double Total = double.Parse(Console.ReadLine());

            double hours = Math.Floor(Total / 60);
            double minutes = Total % 60;

            Console.WriteLine(hours + " hours," + minutes + " minutes");

        }


        static void q8()
        {
            string[] strings = { "This is the first sentence", "The second sentence", "The third sentence is here", "The fourth sentence also here", "The fifth sentence isn't here, I'm joking!" };

            foreach (var item in strings)
            {
                Console.WriteLine("The sentence: " + item + "\rThe length: " + item.Length);
            }


        }

        static void q9(string str)
        {

            string[] strings = str.Split(' ');
            for (int i = 0; i < strings.Length; i++)
            {

                if (strings[i].Length % 2 != 0)
                {
                    strings[i] = new string(strings[i].Reverse().ToArray());
                }
            }

                foreach (var item in strings)
                {
                    Console.WriteLine(item);
                }
            


        }
    }
}
