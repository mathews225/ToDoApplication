using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApplication {
	public class Cli {

		public static string DisplayLine(string prompt) {
			Console.Write($"{prompt}\n");
			var response = Console.ReadLine();
			return response;
		}

		public static string GetString(string prompt) {
			Console.Write($"Enter {prompt}: \n");
			var response = Console.ReadLine();
			return response;
		}
		public static int GetInt(string prompt) {
			var response = GetString(prompt);
			return Convert.ToInt32(response);
		}

		public static DateTime? GetDateTime(string prompt) {
			var response = GetString(prompt);
			if (response.Length==0) {
				return null;
			}
			else {
				return Convert.ToDateTime(response);
			}
		}
	}
}
