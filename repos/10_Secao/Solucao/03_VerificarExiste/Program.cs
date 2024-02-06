using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_VerificarExiste
{
	class Program
	{
		static void Main(string[] args)
		{
			String texto = "Ola amigos do Caio Henrique Maestrello Roza!";

			Console.WriteLine("VErificar existencia no inicio: " + texto.StartsWith("Ola"));

			Console.WriteLine("VErificar existencia no inicio: " + texto.EndsWith("amigos"));

			Console.WriteLine("Verificar existencia: " +texto.Contains("Henrique") );

			Console.ReadKey();
		}
	}
}
