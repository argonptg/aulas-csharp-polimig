class Program
{
    public static void Main()
    {
        double[] vec = new double[20];

        // definição do vetor
        for (int i = 0; i < 20; i++)
        {
            Console.Write("Digite um número real: ");
            vec[i] = double.Parse(Console.ReadLine());
        }

        double big = -99999999;
        double small = 99999999;
        // agora a parte legal (só fui falar isso na 9ª atividade KKKKKKK)
        for (int i = 0; i < 20; i++) // 2 for não é legal mas nesse caso é ok
        {
            if (vec[i] > big) big = vec[i];
            if (vec[i] < small) small = vec[i];
        }
        
        Console.WriteLine($"O menor elemento no vetor é {small}");
        Console.WriteLine($"O maior elemento no vetor {big}");
    }
}