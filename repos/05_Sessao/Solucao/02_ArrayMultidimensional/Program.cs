using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ArrayMultidimensional
{
	class Program
	{
		static void Main(string[] args)
		{
			string[,] marcas = new string[3, 3];

			marcas[0,0] = "FIAT";
			marcas[0,1] = "Nissam";
			marcas[0,2] = "Renault";

			marcas[1,0] = "HP";
			marcas[1,1] = "DELL";
			marcas[1,2] = "Lenovo";

			marcas[2,0] = "";
			marcas[2,1] = "";
			marcas[2,2] = "";

		}
	}
}
