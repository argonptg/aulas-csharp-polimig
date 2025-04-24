namespace Atividade9;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite a quantidade de números a ser lido: ");
        int n = int.Parse(Console.ReadLine());
        
        int[] numeros = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Digite o numero: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }
        
        Console.WriteLine($"A média é {numeros.Average()}");
    }
}