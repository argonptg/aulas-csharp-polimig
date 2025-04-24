class Program
{
    public static void Main(String[] args)
    {
        for (int i = 0; i < 40; i++)
        {
            Console.Write("Digite o seu nome: ");
            String nome = Console.ReadLine() ?? string.Empty;
            
            Console.Write("Digite o seu peso em quilos: ");
            double peso = double.Parse(Console.ReadLine() ?? string.Empty);
            
            Console.Write("Digite a sua altura em metros: ");
            double altura = double.Parse(Console.ReadLine() ?? string.Empty);
            
            double imc = peso / Math.Pow(altura, 2);
            Console.WriteLine($"IMC: {imc:F2}");

            if (imc > 23)
            {
                Console.WriteLine("IMC acima de 23!");
            }
        }
    }
}