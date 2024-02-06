using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Sobrecarga
{
	class Pessoa
	{

		public int Andar() {

			return 1;
		
		}

		public int Andar(int lvl)
		{
			return Andar(1) * lvl;
		}

		public int Andar(string lvl)
		{
			return Andar("1");
		}




		public int Correr() {

			return Andar() * 2;
		}

		public int Pedalar() {

			return Andar() * 4;
				
		}

	}
}
