class Program
{
    public static void Main()
    {
        double[] vec = new double[12];
        int inRange = 0;

        for (int i = 0; i < 12; i++)
        {
            Console.Write("Digite um número real: ");
            vec[i] = double.Parse(Console.ReadLine());

            if (vec[i] > 10 && vec[i] < 45) inRange++;
        }
        
        Console.WriteLine($"Vetor final: {{{string.Join(", ", vec)}}}");
        Console.WriteLine($"Soma dos valores: {vec.Sum()}");
        Console.WriteLine($"Números acima de 10 e abaixo de 45: {inRange}");
    }
}