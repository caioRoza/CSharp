using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_ConversãoTextoParaNumero
{
	class Program
	{
		static void Main(string[] args)
		{
			string numeroTexto = "30";
			int numero1 = int.Parse(numeroTexto) ;
			int numero2 = 30;

			Console.Write("O resultado da Soma é: " + (numero1 + numero2));
			Console.ReadKey();
		}
	}
}
