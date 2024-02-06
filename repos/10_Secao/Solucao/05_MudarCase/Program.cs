using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_MudarCase
{
	class Program
	{
		static void Main(string[] args)
		{
			String texto = "Ola amiguinhos, feliz ano novo";

			Console.WriteLine(texto.ToUpper());
			Console.WriteLine(texto.ToLower());

			Console.ReadKey();
		}
	}
}
