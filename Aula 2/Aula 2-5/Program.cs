/*
 * Criado por SharpDevelop.
 * Usuário: POLIMIG
 * Data: 14/02/2025
 * Hora: 09:45
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;

namespace Aula2_5
{
	class Program
	{
		public static void Main(string[] args)
		{
			while (true)
			{
				Console.WriteLine("1. Pesquisar");
				Console.WriteLine("2. Cadastrar");
				Console.WriteLine("3. Excluir");
				Console.WriteLine("4. Voltar");
				Console.WriteLine("-1. Sair");
				Console.Write("?: ");
				int opt = int.Parse(Console.ReadLine());
				
				if (opt == -1)
					break;
				
				switch (opt)
				{
					case 1:
						Console.WriteLine("Usuário escolheu a opção 1. Pesquisar");
						break;
					case 2:
						Console.WriteLine("Usuário escolheu a opção 2. Cadastrar");
						break;
					case 3:
						Console.WriteLine("Usuário escolheu a opção 3. Excluir");
						break;
					case 4:
						Console.WriteLine("Usuário escolheu a opção 4. Voltar");
						break;
				}
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}