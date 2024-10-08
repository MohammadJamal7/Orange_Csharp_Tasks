using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task6_functions3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // getDays(new DateTime(2024,7,1), new DateTime(2024,8,20));
            //numInStr(new string[] { "mohammad", "mo7ammad", "sami", "234ali" });
            //reverseOdd("mohammad Jamal Huessien");
            pandigitalNumber(1023456789);


        }

        static void getDays(DateTime startDate, DateTime endDate)
        {

            TimeSpan difference = endDate - startDate;

            Console.WriteLine("The days between these dates are :" + difference.Days + " day.");
        }

        static void numInStr(string[] arr)
        {
            List<string> list = new List<string>();
            foreach (var item in arr)
            {
                if (Regex.IsMatch(item, @"\d+"))
                {
                    list.Add(item.ToString());
                }
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }


        static void reverseOdd(string str)
        {
            string[] arr = str.Split(' ');
            for (int i = 1; i <= arr.Length; i++)
            {
                if (i%2!=0)
                {
                    arr[i] = new string(arr[i].Reverse().ToArray());
                }

            }
            string newString = String.Join(" ", arr);
             
            Console.WriteLine(newString);

        }

        static void pandigitalNumber(int number)
        {
            int[] nums = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string numString = number.ToString();
            foreach (var num in nums)
            {
                if (!numString.Contains(num.ToString()))
                {
                    Console.WriteLine("Isn't pandigital!");
                    return; 
                }
            }

            Console.WriteLine("It is pandigital!");
        }
    }
}