/*
 * Criado por SharpDevelop.
 * Usuário: POLIMIG
 * Data: 21/02/2025
 * Hora: 09:52
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Windows.Forms;

namespace Aula3_3
{
	class Program
	{
		public static void Main(string[] args)
		{
			for (int i = 0; i < 20; i++)
			{
				Console.Write("Escreva um número inteiro: ");
				int num = int.Parse(Console.ReadLine());
				
				if (num < 0)
				{
					MessageBox.Show("Número menor que zero", "Seloko num compensa");
				}
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}