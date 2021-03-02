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


		void ListAllToDos() {
			Cli.DisplayLine("Called ListAllToDos()");
		} 


		void Run() {
			Cli.DisplayLine("ToDo Application");
			var option = DisplayMenu();
			while (option != 0) {
				switch (option) {
					case 1:
						ListAllToDos();
						break;
					case 0:
						return;
					default:
						Cli.DisplayLine("Invalid option");
						break;
				}
				option = DisplayMenu();
			}
		}

		void DisplayMenu() {
			Cli.DisplayLine("Menu:");
			Cli.DisplayLine("1 | List All ToDo");
			Cli.DisplayLine("2 | Exit");
			var options = Cli.GetInt("Menu Option");
			return options;
		}

		static void Main(string[] args) {
			var pgm = new Program();
			pgm.Run();
		}
	}
}
