/*
 * Criado por SharpDevelop.
 * Usuário: POLIMIG
 * Data: 14/03/2025
 * Hora: 10:48
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;

namespace Aula_5_3
{
	class Program
	{
		public static void Main(string[] args)
		{
			double val_t = 0, 
				   juros = 0, 
				   parcela = 0,
				   empr = 0;
				   
			int qnt_p = 0;
			
			Console.Write("Digite o valor do impréstimo: ");
			bool sucesso = double.TryParse(Console.ReadLine(), out empr);

			Console.WriteLine("A - 12 parcelas, 25% de juros");
			Console.WriteLine("B - 24 parcelas, 50% de juros");
			Console.WriteLine("C - 36 parcelas, 90% de juros");
			Console.Write("?: ");
			
			string op = Console.ReadLine().ToLower();
			
			switch (op) 
			{
				case "a":
					juros = empr * 0.25;
					val_t = empr + juros;
					
					qnt_p = 12;
					parcela = val_t / qnt_p;
					break;
				case "b":
					juros = empr * 0.5;
					val_t = empr + juros;
					
					qnt_p = 24;
					parcela = val_t / qnt_p;
					break;
				case "c":
					juros = empr * 0.90;
					val_t = empr + juros;
					
					qnt_p = 36;
					parcela = val_t / qnt_p;
					break;
				default:
					Console.WriteLine("Escolha inválida.");
					break;
			}
			
			if (sucesso)
			{
				Console.WriteLine("\n\nValor original do empréstimo: R$" + empr);
				Console.WriteLine("Quantidade de parcelas: " + qnt_p);
				Console.WriteLine("--------------------");
				
				Console.WriteLine("Valor total do empréstimo: R$" + val_t);
				Console.WriteLine("Valor dos juros: R$" + juros);
				Console.WriteLine("Valor de cada parcela: R$" + parcela);			
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}