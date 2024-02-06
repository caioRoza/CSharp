using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RemoverEspaço
{
	class Program
	{
		static void Main(string[] args)
		{
			String texto = "        Olá Amigos do Caio Roza!             " +
				"";

			Console.WriteLine(texto.TrimStart());
			Console.WriteLine(texto.TrimEnd());
			Console.WriteLine(texto.Trim());

			Console.ReadKey();

		}
	}
}
