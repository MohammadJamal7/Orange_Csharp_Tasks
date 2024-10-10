using System;
using System.IO;

namespace ReadyAndWriteFromFile
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string lines = "";
			string path = @"C:\Users\pc\Desktop\info.txt";

			//Question 1 
			using (StreamWriter writer = new StreamWriter(path)) {

				writer.WriteLine("Moahammad ");
				writer.WriteLine("Software engineer, fullstack deveoper using .Net ");
				writer.WriteLine("I'm 21 years old ");
				writer.WriteLine("I'm in my final season in the college and currently, I'm taking an internship in Orange in Fullstack web development using .Net");
			}

			//Quesiton 2
			using (StreamReader reader = new StreamReader(path)) {

				string line;
				while ((line = reader.ReadLine()) != null) { lines += line + "\n"; }

			}

			//Question 3
			int lattersCounter = 0;
			for (int i = 0; i < lines.Length; i++)
			{
				if(char.IsLetter(lines[i])) { 
				lattersCounter++;
				}
			}
            Console.WriteLine("The number of latters in the file equals :"+lattersCounter);
            Console.WriteLine("************************");

			//Questoin 4
			string[] chars = lines.Split(' ');

			//int counter = chars.Length;
			int wordsCounter = 0;
			foreach (var item in chars)
			{
				++wordsCounter;
               
            }
            Console.WriteLine("The number of words in the file equals :"+ wordsCounter);

		}
	}
}


