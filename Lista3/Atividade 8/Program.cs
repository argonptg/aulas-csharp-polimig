class Program
{
    public static void Main()
    {
        int[] vec = new int[10];
        bool loop = true;
        
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Digite um valor: ");
            vec[i] = int.Parse(Console.ReadLine());
        }
        
        // algoritimo básico de linear search
        // é um loop na array inteira, se achar o elemento, ótimo!
        // se não, passa pro próximo
        // se não achar em nenhum dos índices então fala que não tem.
        while (loop)
        {
            Console.Write("Digite um número para pesquisar: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < vec.Length; i++)
            {
                if (vec[i] == n)
                {
                    Console.WriteLine($"Elemento achado no índice {i}!");
                    loop = false;
                    break;
                }

                if (vec[i] != n && i == (vec.Length - 1))
                {
                    Console.WriteLine($"Número não está no vetor.");
                }
            }
        }
    }
}