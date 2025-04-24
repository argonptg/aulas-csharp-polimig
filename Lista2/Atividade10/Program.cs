namespace Atividade10;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a quantidade de funcionários: ");
        int n = int.Parse(Console.ReadLine());
        double[] sal = new double[n];
        
        for (int i = 0; i < n; i++)
        {
            Console.Write("Digite o seu salario: ");
            sal[i] = double.Parse(Console.ReadLine());
        }
        
        Console.WriteLine($"Número de Funcionários: {n}");
        Console.WriteLine($"Média Salarial: {sal.Average()}");
    }
}