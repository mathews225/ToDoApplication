using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApplication {
	public class Cli {

		public static string GetString(string prompt) {
			Console.Write($"{prompt}");
			var response = Console.ReadLine();
			return response;
		}

	}
}
