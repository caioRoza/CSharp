using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_Sobrescrita.Biblioteca;

namespace _02_Sobrescrita
{
	class Program
	{
		static void Main(string[] args)
		{
			Carro carro = new Carro();
			Moto moto = new Moto();
			Veiculo vei = new Veiculo();


			carro.Marca = "FIAT";
			moto.Marca = "Honda";
			vei.Marca = "AirBus";

			carro.Mover();
			moto.Mover();
			vei.Mover();

			Console.ReadKey();
		}
	}
}
