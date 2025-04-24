namespace Atividade8;

class Program
{
    static void Main(string[] args)
    {
        double a1 = 1000 / 1;
        double a2 = 997 / 2;
        double an = a1;

        double r = a2 - a1;

        for (int i = 1; i <= 50; i++)
        {
            an = an + r;
            Console.WriteLine(an);
        }
    }
}