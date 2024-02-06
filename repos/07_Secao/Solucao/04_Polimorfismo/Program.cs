using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04_Polimorfismo.Biblioteca.Derivado;
using _04_Polimorfismo.Biblioteca;

namespace _04_Polimorfismo
{
	class Program
	{
		static void Main(string[] args)
		{

			Moto moto = new Moto();
			MoverVeiculo(moto);


			Carro carro = new Carro();
			MoverVeiculo(carro);

			Console.ReadKey();
		}

		public static void MoverVeiculo(Veiculo veiculo)
		{
			veiculo.Mover();
		}
	}
}
