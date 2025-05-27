class Program
{
    public static void Main()
    {
        // se quiser editar os valores dos vetores
        // vai no hardcode msm
        // até que dá pra colocar o usuário pra escrever
        // os vetores mas o código ia ficar
        // 1. enorme
        // 2. dificil de testar
        int[] vec1 = new int[12] { 42, 88, 7, 91, 23, 56, 74, 15, 60, 3, 99, 31 };
        int[] vec2 = new int[12] { 19, 65, 8, 33, 72, 4, 80, 51, 95, 27, 68, 11 };
        
        int[] vecDif = new int[12];

        for (int i = 0; i < 12; i++)
        {
            vecDif[i] = vec1[i] - vec2[i];
        }
        
        Console.WriteLine($"A diferença dos dois vetores é: {string.Join(", ", vecDif)}");
    }
}