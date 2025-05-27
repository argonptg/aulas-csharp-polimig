class Program
{
    public static void Main()
    {
        double[] vec = new double[35];
        double evenSum = 0;
        int[] negPos = new int[35];

        for (int i = 0; i < 35; i++)
        {
            int negIndex = 0;
            
            Console.Write("Digite um número: ");
            vec[i] = double.Parse(Console.ReadLine());

            if (vec[i] < 0)
            {
                negPos[negIndex] = i; 
                negIndex++;
            }
            if (i % 2 == 0) evenSum += vec[i];
        }
        
        Console.WriteLine($"Soma dos números em índices Pares: {evenSum}");
        Console.WriteLine($"Índices cujo possuem números negativos: {string.Join(", ",  negPos)}");
        Console.WriteLine($"Média aritimética: {vec.Average()}");
    }
}