using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_EstCondicional_IF
{
	class Program
	{
		static void Main(string[] args)
		{
			string valorPoupancaTexto;
			float valorPoupanca;
			Console.Write("Digite o valor que possui na poupança:");
			valorPoupancaTexto = Console.ReadLine();
			valorPoupanca = float.Parse(valorPoupancaTexto);

			if (valorPoupanca >= 100000){
				Console.Write("Você possui juros diferenciados");
			}else if (valorPoupanca > 50000) {
				Console.Write("Voce tem uma taxa de juros de 1.2%");		
			} else {
				Console.Write("Seus juros são normais");
			}

			Console.ReadKey();
		}
	}
}
