using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Polimorfismo.Biblioteca
{
	class Veiculo
	{
		public string Marca;
		public string Modelo;
		public string Ano;

		public virtual void Mover() {
			Console.WriteLine("Veículo se movendo");
		}
	}
}
