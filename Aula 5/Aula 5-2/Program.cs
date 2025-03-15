/*
 * Criado por SharpDevelop.
 * Usuário: POLIMIG
 * Data: 14/03/2025
 * Hora: 10:35
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;

namespace Aula_5_2
{
	class Program
	{
		public static void Main(string[] args)
		{
			double res = 0, num1;
			
			Console.Write("Digite um número real: ");
			bool sucesso = double.TryParse(Console.ReadLine(), out num1);
			
			Console.WriteLine("A - Calcula quadrado do número");
			Console.WriteLine("B - Calcula raiz quadrada do número");
			Console.WriteLine("C - Calcula metade do número");
			Console.WriteLine("D - Calcula dobro do número");
			Console.Write("Escolha uma opção: ");
		
			string op = Console.ReadLine().ToLower();
			
			switch (op)
			{
				case "a":
					res = Math.Pow(num1, 2);
					break;
				case "b":
					res = Math.Sqrt(num1);
					break;
				case "c":
					res = num1 / 2;
					break;
				case "d":
					res = num1 * 2;
					break;
				default:
					Console.WriteLine("Escolha inválida");
					break;
			}
			
			if (sucesso)
				Console.WriteLine("O resultado é: " + res);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}