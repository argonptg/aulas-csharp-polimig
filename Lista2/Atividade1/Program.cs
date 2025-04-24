namespace Atividade1;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 50; i++)
        {
            Console.Write("Digite a base de um triângulo: ");
            float baseTri = float.Parse(Console.ReadLine() ?? string.Empty);
            
            Console.Write("Digite a altura de um triângulo: ");
            float altTri = float.Parse(Console.ReadLine() ?? string.Empty);
            
            Console.WriteLine($"Área: {(baseTri * altTri) / 2}\n=======================");
        }
    }
}