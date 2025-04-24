namespace Atividade7;

class Program
{
    static void Main()
    {
        const int n = 500;

        double totBru = 0.0;
        double totImp = 0.0;
        double totLiq = 0.0;

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Nota {i}");

            Console.Write("Nome do produto: ");
            string nome = Console.ReadLine();

            Console.Write("Valor do produto: ");
            double val = double.Parse(Console.ReadLine());

            Console.Write("Imposto sobre o produto: ");
            double imp = double.Parse(Console.ReadLine());

            totBru += val;
            totImp += imp;
            totLiq += val - imp;

            Console.WriteLine(); // quebra de linha entre notas
        }

        Console.WriteLine("---------- RESUMO ----------");
        Console.WriteLine("Total Bruto: R$ " + totBru.ToString("F2"));
        Console.WriteLine("Total Imposto: R$ " + totImp.ToString("F2"));
        Console.WriteLine("Total Líquido: R$ " + totLiq.ToString("F2"));
    }
}
