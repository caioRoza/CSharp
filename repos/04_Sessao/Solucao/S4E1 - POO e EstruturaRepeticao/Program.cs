using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S4E1___POO_e_EstruturaRepeticao
{
	class Program
	{
		static void Main(string[] args)
		{
			int resultado = Matematica.Exponenciacao(2, 4);

			Console.WriteLine("2 elevado a 4 é: " + resultado);

			Console.ReadKey();
		}
	}
}
