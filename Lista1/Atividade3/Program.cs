class Program
{
    public static void Main(String[] args)
    {
        int tot = 0;
        int acm650 = 0;
        
        for (int i = 0; i <= 1000; i += 3)
        {
            tot = tot + i;
            
            if (i > 650) acm650++;
        }
        
        Console.WriteLine($"Soma de todos os números: {tot}");
        Console.WriteLine($"Números acima de 650: {acm650}");
    }
}