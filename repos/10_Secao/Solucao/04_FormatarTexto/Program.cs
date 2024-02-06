using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_FormatarTexto
{
	class Program
	{
		static void Main(string[] args)
		{
			string nome = "Caio Roza";
			string texto = "Bem vindo" + nome + "Feliz natal";


			string textoFormatado = String.Format("Bem vindo {0}! Feliz natal {0} {1}", nome, "Feliz");

			Console.WriteLine(texto);
			Console.WriteLine(textoFormatado);

			Console.ReadKey();
		}
	}
}
