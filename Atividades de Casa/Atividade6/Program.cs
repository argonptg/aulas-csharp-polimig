class Program
{
    public static void Main(String[] args)
    {
        int[] tot = [];
        
        for (int i = 0; i < 30; i++)
        {
            Console.Write("Digite um número: ");
            int num = int.Parse(Console.ReadLine() ?? string.Empty);

            if (num >= 15 && num <= 30)
            {
                Console.WriteLine("Entre 15 e 30!");
            }
        }
        
        // novamente utilizo magia da linguagem pra facilitar
        Console.WriteLine($"Soma de todos os números: {tot.Sum()}");
        Console.WriteLine($"Média de todos os números: {tot.Average()}");
    }
}