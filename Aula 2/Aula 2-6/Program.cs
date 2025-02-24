/*
 * Criado por SharpDevelop.
 * Usuário: POLIMIG
 * Data: 14/02/2025
 * Hora: 09:53
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;

namespace Aula2_6
{
	class Program
	{
		public static void Main(string[] args)
		{
			int acumulador = 0;
			
			for (int i =0; i<=500; i++)
			{
				acumulador= acumulador+ i;
				Console.WriteLine(i + ": " + acumulador);
				
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}