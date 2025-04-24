using System;

class Program
{
    public static void Main(String[] args)
    {
        for (int i = 0; i < 200; i++)
        {
            Console.WriteLine($"Número: {i}");
            Console.WriteLine($"Quadrado: {Math.Pow(i, 2)}");
            Console.WriteLine($"Raiz: {Math.Sqrt(i)}");
            Console.WriteLine("=======================");
        }
    }
}
