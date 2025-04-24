namespace Atividade5;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número: ");
        long a1 = long.Parse(Console.ReadLine() ?? string.Empty);
        long ret = a1;
        
        for (int i = 1; i <= 20; i++)
        {
            Console.WriteLine($"a{i} = {ret}");
            ret = ret * i;
        }
    }
}