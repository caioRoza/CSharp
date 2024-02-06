using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ComentarioDoc
{
	/// <summary>
	/// Está Classe é responsável por gerenciar todos os comportamentos genéricos de um veiculo.
	/// </summary>
	class Veiculo{
		 /// <summary>
		 /// Marca do Veículo.
		 /// </summary>
		public string Marca;

		/// <summary>
		/// Método responsável por mover o veículo
		/// </summary>
		/// <param name="medida"> 0 - Metros, 1 - Kilometros </param>
		public void  Mover(int medida) { }
	}
}
