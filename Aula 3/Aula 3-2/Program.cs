/*
 * Criado por SharpDevelop.
 * Usuário: POLIMIG
 * Data: 21/02/2025
 * Hora: 09:42
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;

namespace Aula3_2
{
	class Program
	{
		public static void Main(string[] args)
		{
			string nome = "";
			double nota1, nota2, nota3, media = 0;
			
			Console.Write("Digite o nome do aluno: ");
			nome = Console.ReadLine();
			Console.Write("Digite a 1ª nota do aluno: ");
			nota1 = double.Parse(Console.ReadLine());
			Console.Write("Digite a 2ª nota do aluno: ");
			nota2 = double.Parse(Console.ReadLine());
			Console.Write("Digite a 3ª nota do aluno: ");
			nota3 = double.Parse(Console.ReadLine());
			
			media = (nota1 + nota2 + nota3) / 3;
			
			Console.WriteLine("O aluno: " + nome);
			Console.WriteLine("Obteve a média: " + media);
			
			Console.Write("A situação dele foi: ");
			if (media >= 60) 
			{
				Console.WriteLine("Aprovado - Parabens!!");
			} else {
				Console.WriteLine("Reprovado - Precisa estudar mais!!");
			}
						
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}