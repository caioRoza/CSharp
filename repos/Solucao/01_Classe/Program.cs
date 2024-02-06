using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _01_Classe.Veiculo;

namespace _01_Classe
{
	class Program
	{
		static void Main(string[] args)
		{
			Carro carro1 = new Carro();
			Carro carro2 = new Carro();

			Console.WriteLine("Marca: " + carro1.marca);
			carro1.marca = "Ford";
			Console.WriteLine("Marca: " + carro1.marca);

			Console.WriteLine("Marca: " + carro2.marca);

			Console.WriteLine("Luzes internas:" + carro1.luzesInternas);
			carro1.abrirPorta();
			Console.WriteLine("Luzes internas:" + carro1.luzesInternas);


			string statusFarol = carro1.acenderFarolAutomaticamente();
			Console.WriteLine("Status do farol: " + statusFarol);



			Console.ReadKey();

			

		}
	}
}
