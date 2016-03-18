using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AVAi;

namespace Test {
	class Program {
		static string Prompt() {
			string In = "";
			while (In.Length == 0) {
				Console.Write("$ ");
				In = Console.ReadLine().Trim();
			}
			return In;
		}

		static void Main(string[] args) {
			Console.Title = "AVA AI Test";

			AI Ava = new AI();

			while (true)
				Ava.Process(Prompt());

			/*Console.WriteLine("Done!");
			Console.ReadLine();*/
		}
	}
}
