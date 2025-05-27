class Program
{
    public static void Main()
    {
        double[] precoLitro = new double[10];
        int precoCaro = 0;
        
        for (int i = 0; i < precoLitro.Length; i++)
        {
            Console.Write("Digite o preço do litro no posto: ");
            precoLitro[i] = double.Parse(Console.ReadLine());

            if (precoLitro[i] > 6.50) precoCaro++;
        }
        
        Console.WriteLine($"O litro está mais caro em {precoCaro} postos");
        Console.WriteLine($"O preço médio é R${precoLitro.Average()}");
    }
}