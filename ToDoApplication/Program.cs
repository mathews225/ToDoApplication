using System;

#region SetUp
/* 1. Add ToDoLibrary
 * 2. Link App to Library
 * 3. Add Tools and SqlServer to Lib and Design to App
 *
 */ 
#endregion

namespace ToDoApplication {
	class Program {
		static void Main(string[] args) {


			var input = Cli.GetString("Enter a string:\n");
			Console.WriteLine($"\nInput is '{input}'");

			
		}
	}
}
