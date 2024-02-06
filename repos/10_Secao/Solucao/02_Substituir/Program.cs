using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Substituir
{
	class Program
	{
		static void Main(string[] args)
		{
			String texto = "Ola amigos do João.";

			String textoSub = texto.Replace("João", "José");
			Console.WriteLine(texto);
			Console.WriteLine(textoSub);
			Console.WriteLine(texto);

			Console.ReadKey();

		}
	}
}
