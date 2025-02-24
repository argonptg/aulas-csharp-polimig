/*
 * Criado por SharpDevelop.
 * Usuário: POLIMIG
 * Data: 21/02/2025
 * Hora: 09:28
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;

namespace Aula3_1
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Nome do Candidato:");
			string nom = Console.ReadLine();
			Console.Write("Idade do Candidato:");
			int idad = int.Parse(Console.ReadLine());
			Console.Write("Altura do Candidato:");
			double alt = double.Parse(Console.ReadLine());
			if(idad>18)
				Console.Write("Maior de 18 anos!");
			if(alt>1.65)
				Console.Write("Altura maior de 1.65");
			if(idad > 18 && alt > 1.65)
				Console.Write("Permitido a entrada");
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}