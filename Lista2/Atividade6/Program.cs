namespace Atividade6;

class Program
{
    static void Main(string[] args)
    {
        int tot = 0;
        Console.Write("Digite o número de alunos: ");
        int x = int.Parse(Console.ReadLine() ?? string.Empty);

        for (int i = 0; i < x; i++)
        {
            Console.Write("Digite o seu nome: ");
            string nome = Console.ReadLine() ?? string.Empty;

            Console.Write("Digite a sua idade: ");
            int idade = int.Parse(Console.ReadLine() ?? string.Empty);

            Console.Write("Digite o seu sexo: ");
            string sexo = Console.ReadLine() ?? string.Empty;

            tot++;
        }
        
        Console.WriteLine($"Total de alunos: {tot}");
    }
}