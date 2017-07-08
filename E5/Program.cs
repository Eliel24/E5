using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E5
{
	class Program
	{
		static void Main(string[] args)
		{
			int nota1, nota2, nota3;
			int Promedio;
			string entrada;
			Console.Write("Introzducir la primera Nota: ");
			entrada = Console.ReadLine();
			nota1 = Convert.ToInt32(entrada);
			Console.WriteLine();
			Console.Write("Introzducir la segunda Nota: ");
			entrada = Console.ReadLine();
			nota2 = Convert.ToInt32(entrada);
			Console.WriteLine();
			Console.Write("Introzducir la tercera Nota: ");
			entrada = Console.ReadLine();
			nota3 = Convert.ToInt32(entrada);
			Promedio = (nota1 + nota2 + nota3) / 3;
			Console.WriteLine();
			if (Promedio >= 7)
			{
				Console.Write("Promocionado");
			}
			Console.ReadKey();
		}
	}
}
