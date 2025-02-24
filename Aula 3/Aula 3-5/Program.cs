/*
 * Criado por SharpDevelop.
 * Usuário: POLIMIG
 * Data: 21/02/2025
 * Hora: 10:25
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;

namespace Aula3_5
{
	class Program
	{
		public static void Main(string[] args)
		{
			while (true)
			{
				Console.Write("1. Somar\n2. Subtrair\n3. Multiplicar\n4. Dividir\n-1. Sair\n");
				Console.Write("?: ");
				int op = int.Parse(Console.ReadLine());
				
				if (op == -1) break;
				
				Console.Write("Digite um número: ");
				int num1 = int.Parse(Console.ReadLine());
				
				Console.Write("Digite outro número: ");
				int num2 = int.Parse(Console.ReadLine());
				
				switch(op)
				{
					case 1:
						Console.WriteLine("A soma é: " + (num1 + num2));
						break;
					case 2:
						Console.WriteLine("A subtração é: " + (num1 - num2));
						break;
					case 3:
						Console.WriteLine("A multiplicação é: " + (num1 * num2));
						break;
					case 4:
						Console.WriteLine("A divisão é: " + (num1 / num2));
						break;
					default:
						Console.WriteLine("Escolha inválida");
						break;
				}
				
				System.Threading.Thread.Sleep(2000); // Para por 2seg
				Console.Clear();
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}