using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             

Correct the syntax error:

string [ ] ARR= [ 1,7  9  45, ]
int arr2=["Str" "alex","moh"]
string arr3= ['the','fox' ,'over', lazy, 'dog',  ]

What the index of "Banana","Tomato"?
String [ ]  fruits=["Tomato","Banana","Watermelon"]
            // 1 for Banana, 0 for Tomato

Create an multiple arrays that represents your:
Favorite Food (5 item)
Favorite Sport (3 item)
Favorite Movie (4 item)
Then, print each array using foreach, and Loop Through an Array
            */
            string[] food = { "food1", "food2", "food3", "food4", "food5" };
            string[] Sports = { "sport1", "sport2", "sport3" };
            string[] movies = { "movie1", "moview2", "moview3", "moview4" };

            foreach (var item in Sports)
            {
                Console.WriteLine(item);
            }
            foreach (var item in food)
            {
                Console.WriteLine(item);
            }
            foreach (var item in movies)
            {
                Console.WriteLine(item);
            }

            /*

Write a program in C# to calculate the sum of three numbers with getting input in one line separated by a comma
Expected Output:
Input three numbers separated by comma: 5,10,15
The sum of three numbers: 30.
*/
            string []inpt = Console.ReadLine().Split(',');
            double[] doubles = new double[inpt.Length];
            double sum = 0;
            for (int i = 0; i < inpt.Length; i++) {
                doubles[i] = double.Parse(inpt[i]);
            }

            foreach (var item in doubles)
            {
                sum += item;
            }
            Console.WriteLine(sum);
            /*
Write a program in C# to display the n terms of odd number and their sum from [1- 100 ]. 
Test Data
The odd numbers are1 3 5 7 9 11 13 15 17 19……
The Sum of odd Numbers is: …...
            */
            
                int counter = 1;
                int summ = 0;
                while (counter <= 100)
            { 


                if (counter%2!=0)
                {
                    Console.WriteLine(counter);
                    summ += counter;
                }
                counter++;
            }


            /*

Write a program in C## to display the pattern like right angle triangle using an asterisk. Go to the editor
The pattern like:
   *
  **
 ***
*/
            int h = 3;
            for (int i = 1; i<=h; i++)
            {
                for (int j = 1; j <= h - i; j++)
                {
                    Console.Write(" ");
                }

                // Print asterisks
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }

                // Move to the next line
                Console.WriteLine();
            }




            /*




           7- Write a program in C# to make such a pattern like right angle triangle with number increased by 1. Go to the editor
           The pattern like :

               1
              2 3
             4 5 6
           7 8 9 10 

            */


            int w = 4;
            int number = 1;

            for (int i = 1; i <= w; i++)
            {
             
                for (int j = 1; j <= w - i; j++)
                {
                    Console.Write(" ");
                }

                
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(number++ + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
