using System;

namespace FunctionDemo2
{
	class Program
	{
		static void Main(string[] args)
		{
			//ScopeDemo();
			StringFunctions();
		}

		static string location;
		static void ScopeDemo()
		{

			// Demonstrate scope and functions that change values of variables
			location = "school";
			string location2 = "school";
			string location3 = "school";
			Console.WriteLine("Location is: " + location);
			Console.WriteLine("Location 2 is: " + location2);
			Console.WriteLine("Location 3 is: " + location3);
			ChangeLocation();
			location3 = ChangeLocation3();
			Console.WriteLine("Location is: " + location);
			Console.WriteLine("Location 2 is: " + location2);
			Console.WriteLine("Location 3 is: " + location3);
		}

		static void ChangeLocation()
		{
			Console.WriteLine("Changing location...");
			location = "Silicon Valley";
			string location2 = "Gisslaved";
		}
		static string ChangeLocation3()
		{
			Console.WriteLine("Changing location...");
			return "Malmö";
		}

		static int Deterministic(int a, int b)
		{
			// This function will, given the same input, always return the same output
			// (no side effects)
			return a * b;
		}
		static string NonDeterministic()
		{
			// This function will return different values every time
			// (no side effects)
			return Console.ReadLine();
		}

		static int index = 0;
		static int GetNext()
		{
			// This function has a side effect - it modifier the global variable INDEX
			index++;
			return index;
		}



		static void StringFunctions()
		{
			Console.WriteLine("Some string functions");
			string example = "crocodile";
			string exampleUpperCase = example.ToUpper();
			if (exampleUpperCase.StartsWith("CROC"))
			{
				Console.WriteLine("crocodile starts with croc");
			}

			Console.WriteLine("Input a string:");
			string input = Console.ReadLine();
			input = input.ToLower();
			Console.WriteLine("Du skrev in: " + input);

			Console.WriteLine("Please enter password:");
			string password = Console.ReadLine().ToLower();
			password = password.Trim();
			if(password == "password")
			{
				Console.WriteLine("Correct password!");
			}
		}

		static string ReadLineNicer()
		{
			string input = Console.ReadLine();
			input = input.ToLower();
			input = input.Trim();
			return input;
		}
	}
}
