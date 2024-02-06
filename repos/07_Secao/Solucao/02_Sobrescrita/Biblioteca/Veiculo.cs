using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Sobrescrita.Biblioteca
{
	class Veiculo
	{

		public string Marca;
		public string Modelo;
		public string QtdMaximaPassageiros;
		public string Ano;


		public virtual void Mover() {

			Console.WriteLine("Mover chamado dentro de: Veiculo.Mover ");
		}
	}
}
