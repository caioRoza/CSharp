using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Construtor
{
	class Carro
	{
		public string Marca;
		public string Modelo;
		
		public Carro() {
			Marca = "Fiat";
			Modelo = "Uno";
		}

		public Carro(string marca, string modelo){
			Marca = marca;
			Modelo = modelo;
		}
	}
}
