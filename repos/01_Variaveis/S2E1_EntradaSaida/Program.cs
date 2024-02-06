using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2E1_EntradaSaida
{
	class Program
	{
		static void Main(string[] args)
		{
			String nome, idade;
			

			Console.WriteLine("Qual seu nome: ");
			nome = Console.ReadLine();
			Console.WriteLine("Agora digite sua idade: ");
			idade = Console.ReadLine();

			int idadeNumero = int.Parse(idade);
			int anoNascimento = DateTime.Now.Year - idadeNumero;

			Console.WriteLine("--------------------------------------");

			Console.WriteLine("Seu nome: " + nome);
			Console.WriteLine("Ano de nascimento é: " + anoNascimento);


			Console.ReadKey();
		}
	}
}
