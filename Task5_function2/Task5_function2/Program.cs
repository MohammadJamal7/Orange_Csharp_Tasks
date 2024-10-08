using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task5_function2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine(q1(20));
            //Console.WriteLine(q2(4));
            //Console.WriteLine(q3(new int[] {1,2,3,4,5,6}));
            //Console.WriteLine(q4(2,4));

            //q5
            //int[] arr = q5(new int[] {1,2,3,4,6,7});
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //q6
            //string[] arr2 = q5(new string[] {"ali","ahmad","Mohammad"});
            //foreach (var item in arr2)
            //{
            //    Console.WriteLine(item);
            //}


        }

        static int q1(int minutes)
        {
            return minutes * 60;
        }

        static int q2(int number) {
            return number + 1;
        }

        static int q3(int[] numbers) {
            return numbers[0];
        }

        static double q4(double bs, double height) { 
           return 0.5 * bs * height;
        }

        static int[] q5(int[] numbers) {
            List<int> evenNumsEvenIndexes = new List<int>();
            for (int i = 0; i < numbers.Length; i++) {
                if (i%2==0 && numbers[i]%2==0)
                {
                    evenNumsEvenIndexes.Add(numbers[i]);
                }
            }

            return evenNumsEvenIndexes.ToArray();
            
        }

        static string[] q6(string[] strings)
        {
            List<string> eventIndexOddLength = new List<string>();
            for (int i = 0; i < strings.Length; i++)
            {
                if (i % 2 == 0 && strings[i].Length % 2 != 0)
                {
                    eventIndexOddLength.Add(strings[i]);
                }
            }

            return eventIndexOddLength.ToArray();

        }

        static int[] q7(int[] nums)
        {
            int[] result = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = (int)Math.Pow(nums[i], i);
            }
            return result;
        }

        static int q8(int a, int b)
        {
            int result = 0;
            for (int i = 0; i < b; i++)
            {
                result += a;
            }
            return result;
        }

        static int q9(int start, int end)
           {
        int result = 1;
        for (int i = start; i <= end; i++)
        {
            result *= i;
        }
        return result;
          }

        static double q10(int[] nums)
        {
            if (nums.Length == 0)
                return 0; 

            double sum = 0;
            foreach (var num in nums)
            {
                sum += num;
            }

            return sum / nums.Length;
        }
        

        
    }
}
