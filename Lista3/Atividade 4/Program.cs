class Program
{
    public static void Main()
    {
        char[] vec = new char[20];
        int hashes = 0;

        for (int i = 0; i < 20; i++)
        {
            Console.Write("Digite um caracter: ");
            char readLine = char.Parse(Console.ReadLine());
            
            vec[i] = readLine == '*' ? '%' : readLine;

            if (vec[i] == '#') hashes++;
        }
        
        Console.WriteLine($"Quantidade de Hashtags: {hashes}");
        Console.WriteLine($"Vetor: {{ {string.Join(", ", vec)} }}");
    }
}