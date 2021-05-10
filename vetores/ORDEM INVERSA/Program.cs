using System;

namespace ORDEM_INVERSA
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = null;
            numeros = new int[15];

            for (var i = 0; i < 15; i++)
            {
                Console.WriteLine("Digite um numero");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] ordemContraria = new int[15];
            int ordemInversa = 0;
            for (var i = 15; i > 0; i--)
            {
                ordemContraria[ordemInversa] = numeros[i-1];
                ordemInversa++;
            }
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            foreach (var item in ordemContraria)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
