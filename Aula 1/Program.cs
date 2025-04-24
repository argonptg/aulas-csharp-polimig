using System;
using System.Collections.Generic;
using System.Linq;

namespace Aula1
{
	class Program
	{
		public static void Main(string[] args)
		{
			string sit = "REPROVADO";
			List<double> notas = new List<double>();

			Console.Write("Digite seu nome: ");
			string nome = Console.ReadLine();

			for (int i = 0; i < 3; i++)
			{
				Console.Write($"Digite a {i + 1}° nota: ");
				notas.Add(double.Parse(Console.ReadLine()));
			}

			double med = notas.Average();

			if (med >= 7)
			{
				sit = "APROVADO";
			}

			Console.WriteLine("Nome: " + nome);

			for (int i = 0; i < 3; i++)
			{
				Console.WriteLine($"{i + 1}° Nota: {notas[i]}");
			}

			Console.WriteLine("Média: " + med);
			Console.WriteLine("Situação: " + sit);

			Console.Write("Aperte qualquer tecla para encerrar...");
			Console.ReadKey(true);
		}
	}
}
