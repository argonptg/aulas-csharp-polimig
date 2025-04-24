namespace Atividade3;

class Program
{
    static void Main(string[] args)
    {
        int acu = 0;

        for (int i = 0; i < 1000; i += 2)
        {
            if (i % 2 == 0) acu = acu + i;
        }
        
        Console.WriteLine($"A soma de todos os números pares entre 0 e 1000 é {acu}");
    }
}