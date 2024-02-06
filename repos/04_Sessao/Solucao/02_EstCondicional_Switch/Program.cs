using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_EstCondicional_Switch
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Qual seu estado Civil? (Digite: S - Solteiro, C - Casado, V - Viúvo, D - Divorciado.)");
			string valor = Console.ReadLine();
			switch (valor)
			{
				case "S":
					Console.Write("Voce está solteiro, Encontre uma parceira.");
					break;
				case "C":
					Console.Write("Voce é casado, prepare uma noite especial.");
					break;
				case "V":
					Console.Write("Voce está viúvo.");
					break;
				case "D":
					Console.Write("Voce é divorciado. Tente Reatar");
					break;


				default:
					Console.Write("Comando não reconhecido");
					break;

			}

			Console.ReadKey();
		}
		
	}
}
