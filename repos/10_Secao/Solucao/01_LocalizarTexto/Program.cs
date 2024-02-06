using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_LocalizarTexto
{
	class Program
	{
		static void Main(string[] args)
		{
			String texto = "Ola amigos, estou muito feliz de estar aqui com vocês. Desejo a todos um feliz ano novo.";
			String palavra = "feliz";

			Console.WriteLine("Tamanho do texto: " + texto.Length);
			Console.WriteLine("Localizar: " + texto.IndexOf(palavra));
			Console.WriteLine("Localizar ultimo: " + texto.LastIndexOf(palavra));


			Console.ReadKey();
		}
	}
}
