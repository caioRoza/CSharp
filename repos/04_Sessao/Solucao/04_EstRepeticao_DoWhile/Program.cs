using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_EstRepeticao_DoWhile
{
	class Program
	{
		static void Main(string[] args)
		{
			bool repetir = false;

			while (repetir) {
				Console.WriteLine("Entrou no \"Whil\"");
			}

			do {
				Console.WriteLine("Entrou no \"do-While\"");
			} while (repetir);

			Console.ReadKey();
		}
	}
}
