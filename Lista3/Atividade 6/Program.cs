class Program
{
    public static void Main()
    {
        int[] vec1 = new int[15];
        int[] vec2 = new int[15];

        int oneBigger = 0;
        int oneSmaller = 0;

        for (int i = 0; i < 15; i++)
        {
            Console.Write("Digite um valor para o Vetor 1: ");
            vec1[i] = int.Parse(Console.ReadLine());
            Console.Write("Digite um valor para o Vetor 2: ");
            vec2[i] = int.Parse(Console.ReadLine());

            if (vec1[i] > vec2[i]) oneBigger++;
            if (vec1[i] < vec2[i]) oneSmaller++;
        }
        
        Console.WriteLine($"{oneBigger} valores são maiores no 1° vetor");
        Console.WriteLine($"{oneSmaller} valores são maiores no 2° vetor");
    }
}