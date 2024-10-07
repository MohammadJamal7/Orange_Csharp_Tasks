using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	public class Program
	{
		static void Main(string[] args)
		{
			Building flat = new Building(1,"this type","Irbid");

			Department dept = new Department();
            Console.WriteLine(dept.Type);

			//Auto properity
			flat.Type = "flat";


			//PProperity
			flat.locProperity = "Irbid";
			Console.WriteLine(flat.locProperity);
		}


		
	}
	public class Building
	{


	

		int id { get; set; }


		
		public string Type { get; set; }


		private string Location;
		public string locProperity
		{
			get { return Location; }
			set { Location = value; }
		}

		public Building() { }
		public Building(int id, string type, string location)
		{
			this.id = id;
			Type = type;
			Location = location;
		}



	}

	public class Department : Building
	{

		

		Department(int id, string ty, double price, string loc)
		{

		}

	}


}



