using System;

namespace Aula_5
{
	class Program
	{
		public static void Main(string[] args)
		{
			while (true) {
				Console.Write("Digite um número de 1 à 7 (-1 = Sair): ");
				int num = int.Parse(Console.ReadLine());
				
				if (num == -1)
				{
					break; // se num é -1 então saia do loop
						   // saindo do app
				}
				
				// switch hell
				switch (num) {
					case 1:
						Console.WriteLine("Domingo");
						break;
					case 2:
						Console.WriteLine("Segunda");
						break;
					case 3:
						Console.WriteLine("Terça");
						break;
					case 4:
						Console.WriteLine("Quarta");
						break;
					case 5:
						Console.WriteLine("Quinta");
						break;
					case 6:
						Console.WriteLine("Sexta");
						break;
					case 7:
						Console.WriteLine("Sábado");
						break;
				}
			}
		}
	}
}