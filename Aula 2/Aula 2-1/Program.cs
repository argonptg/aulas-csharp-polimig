using System;

namespace Aula2_1
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Digite seu nome: ");
			string nome = Console.ReadLine();
			
			Console.Write("Digite seu salário: ");
			double sal = double.Parse(Console.ReadLine());
			
			if (sal <= 3000)
				sal = sal * 1.15;
			else if (sal > 3001 && sal < 5000)
				sal = sal * 1.10;
			else 
				sal = sal * 1.08;
			
			Console.WriteLine("Nome: " + nome);
			Console.WriteLine("Novo salário: " + sal);
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}