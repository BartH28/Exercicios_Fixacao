using System;

namespace Maior_e_menor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o um numero");
            int numero = int.Parse(Console.ReadLine());

            int maior = numero;
            int menor = numero;

            int contador = 1;

            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine($@"Digite o {(contador + 1)}º numero");
                numero = int.Parse(Console.ReadLine());
                contador++;

                if (numero < menor)
                {
                    menor = numero;
                }
                if (numero > maior)
                {
                    maior = numero;
                }

            }

            Console.WriteLine("O maior numero será: "+ maior);
            Console.WriteLine("O menor numero será: "+ menor);

        }
    }
}
