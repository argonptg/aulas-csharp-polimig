using System.Numerics;

namespace Atividade4;

class Program
{
    static void Main(string[] args)
    {
        BigInteger a1 = 3;
        int ratio = 3;
        
        for (int i = 1; i <= 100; i++)
        {
            /*
             * Ai que tá, tem uma limitação critica com PA em computadores
             * esse programa por exemplo excede o limite de 64 bits na cpu
             * logo o num vira negativo (integer overflow)
             * isso é = (2^63 -1) + 1 = -2^63
             *
             * O jeito é importar System.Numerics e usar o tipo BigInteger
             * que usa mais memória para armazenar números maiores.
             */
            
            Console.WriteLine($"a{i} = {a1}"); 
            
            a1 = a1 * ratio;
        }
    }
}