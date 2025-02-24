/*
 * Criado por SharpDevelop.
 * Usuário: POLIMIG
 * Data: 14/02/2025
 * Hora: 10:27
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;

namespace Aula2_7
{
	class Program
	{
		public static void Main(string[] args)
		{			
			Console.Write("qual seu estado");
			string estado= Console.ReadLine();
			Console.Write("qual o valor?");
			double val= double.Parse(Console.ReadLine());
			
			if (estado=="MG")
				val=val*1.25;
			else
				val=val*1.15;
			Console.WriteLine("valor do frete :"+val);
				
		

			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
