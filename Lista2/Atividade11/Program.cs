namespace Atividade11;

class Program
{
    static void Main(string[] args)
    {
        double S = 0.0;

        int num = 1;
        int den = 50;

        while (den >= 1)
        {
            S += 1.0 * num / den;
            num += 2;
            den--;
        }

        Console.WriteLine("O valor de S é: " + S);
    }
}