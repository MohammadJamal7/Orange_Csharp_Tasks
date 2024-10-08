using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
	internal class Program
	{
		static void Main(string[] args)
		{
            //q1();
            //q2(4);
            //q3=>
            //int [] arr = q3(new[] { 3003, 1444, 2343 });
            //         foreach (var item in arr)
            //         {
            //             Console.WriteLine(item);
            //         }

            //q4(21);
            //q5(2, 3, 4);

            //q6(new[] {"Mohammad","Razan"},"MOhammad");

            //q8(1900);

            //q10("this is a string");

        }

		static void q1()
		{
			double sum=0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter mark: ");
                double mark = double.Parse(Console.ReadLine());
				sum += mark;

            }
			Console.WriteLine("The sum is :"+sum +"\nThe AVG i :"+(sum/10));
        }


		static void q2(int counter) {

			double cubed = 0;

			for (int i = 1; i <= counter; i++) {
                Console.WriteLine("The cube of "+i+" equals "+(i*i+i));
			}
		}


		static int[] q3(int[] years) {
			List<int> list = new List<int>();
            for (int i = 0; i < years.Length; i++)
            {
                if (years[i]>1950)
                {
					list.Add(years[i]);
                }
            }
			return list.ToArray();
        }

			
		
		static void q4(int ageyears)
		{
            Console.WriteLine("Your age in days : "+ageyears*365); 
		}

		static void q5(int chiken, int cows, int dogs)
		{

			
            Console.WriteLine("The total of legs: "+(chiken*2+cows*4+dogs*4));


		}


		static void q6(string[]users, string user)
		{
            for (int i = 0; i < users.Length; i++)
            {
                if (users[i].ToLower().Equals(user.ToLower()))
                {
                    Console.WriteLine("Passed!");
                    break;
                }
            }
            Console.WriteLine("Failed");

        }


        static void q7(double num)
        {
            Console.WriteLine(num*num);
        }

       static void q8(int year)
        {

            if (year>=1900 && year<=2024)
            {
                if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                {
                    Console.WriteLine("It's a leap year!");
                }
                else  
                {
                    Console.WriteLine("It's not a leap year!");
                }
            }
            else
            {
                Console.WriteLine("Enter a year between 1900 - 2024");
            }
        }

		static bool q9(int num)
		{
			if (num <= 1)
				return false;

			for (int i = 2; i <= num; i++)
			{
				if (num % i == 0)
					return false;
			}

			return true;
		}

		static void q10(string sentence)
        {
            Console.WriteLine(sentence.Split(' ').Length);
        }

	}

}
