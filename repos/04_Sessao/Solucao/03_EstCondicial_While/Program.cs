using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_EstRepeticao_While
{
	class Program
	{
		static void Main(string[] args)
		{
			int i = 0;
			while (i < 10) {
				Console.WriteLine("Valor atual de i: " + i);
				i++;
			}

			int x = 0;
			bool repetir = true;
			while (repetir) {
				Console.WriteLine("Valor atual de x: " + x);
				x++;
				
				if (x > 20) {
					Console.WriteLine("Saindo do programa");
					repetir = false;
				}
			}

			Console.ReadKey();
		}
	}
}
