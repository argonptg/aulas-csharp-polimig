using System;

namespace Aula2_3
{
	class Program
	{
		public static void Main(string[] args)
		{
			// <tipo> <nome> = <valor>;
			// string user = "rodrigo";
			Console.Write("qual seu nome?");
		
			string nome =Console.ReadLine();
			Console.Write("qual seu sobrenome?");
			string sobrenome = Console.ReadLine();
			Console.WriteLine(nome+ " " +sobrenome);
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}