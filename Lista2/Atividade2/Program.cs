namespace Atividade2;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número: ");
        int x = int.Parse(Console.ReadLine() ?? string.Empty);

        int a1 = x + 1;
        int an = x + 100;
        int n = 100;

        // jeito bem mais fácil e eficiente do que usar um for/while
        int sum = ((a1 + an) * n) / 2;
        Console.WriteLine(sum);
    }
}