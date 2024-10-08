using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();

           
            Intro intro = new Intro();
            intro.ShowMessage("Scott");

            
            Factorial factorial = new Factorial();
            Console.WriteLine("Factorial of 5: " + factorial.Calculate(5));

            
            ArraySort arraySort = new ArraySort();
            arraySort.SortArray();

           
            DateDifference dateDifference = new DateDifference();
            DateTime date1 = new DateTime(1981, 11, 03);
            DateTime date2 = new DateTime(2013, 09, 04);
            dateDifference.CalculateDifference(date1, date2);

            
            DateConverter dateConverter = new DateConverter();
            dateConverter.ConvertStringToDate("12-08-2004");
        }
    }


    class MyClass
    {
        public MyClass()
        {
            Console.WriteLine("MyClass class has initialized!");
        }
    }

    class Intro
    {
        public void ShowMessage(string name)
        {
            Console.WriteLine($"Hello All, I am {name}");
        }
    }

    class Factorial
    {
        public int Calculate(int num)
        {
            if (num <= 1) return 1;
            return num * Calculate(num - 1);
        }
    }

    class ArraySort
    {
        public void SortArray()
        {
            int[] array = { 11, -2, 4, 35, 0, 8, -9 };
            Array.Sort(array);
            Console.WriteLine("Sorted array: " + string.Join(" ", array));
        }
    }

    class DateDifference
    {
        public void CalculateDifference(DateTime date1, DateTime date2)
        {
            TimeSpan diff = date2 - date1;
            DateTime zeroTime = new DateTime(1, 1, 1);
            DateTime age = zeroTime + diff;
            Console.WriteLine($"Difference: {age.Year - 1} years {age.Month - 1} months {age.Day - 1} days");
        }
    }

    class DateConverter
    {
        public void ConvertStringToDate(string dateString)
        {
            DateTime date = DateTime.ParseExact(dateString, "dd-MM-yyyy", null);
            Console.WriteLine($"Converted Date: {date.ToString("yyyy-MM-dd")}");
        }
    }
}
