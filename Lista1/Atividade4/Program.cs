class Program
{
    public static void Main(String[] args)
    {
        int[] tot = [];

        for (int i = 0; i < 50; i++)
        {
            Console.Write($"Digite o {i + 1}° número: ");
            tot[i] = int.Parse(Console.ReadLine() ?? string.Empty);



            if (i % 7 == 0)
            {
                Console.WriteLine($"{i} é Divisível por 7!");
            }
        }

        // prefiro usar magia da linguagem do que fazer manual
        // mas não quer dizer que não sei
        Console.WriteLine($"Soma de todos os números {tot.Sum()}");
        Console.WriteLine($"Média de todos os números {tot.Average()}");
    }
}
