using System;

namespace vetores
{
    class Program
    {
        static void Main(string[] args)
        {   
            string[] nomes = null;
            nomes = new string[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite o nome de uma pessoa:");
                nomes[i] =  Console.ReadLine();
            }

            Console.WriteLine("Digite mais um nome");
            string nome_b = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            if (nome_b == nomes[0])
            {
                Console.WriteLine("ACHEI PORRA!!! Este nome  está na lista :)");
            }
            else if (nome_b == nomes[1])
            {
                Console.WriteLine("ACHEI PORRA!!! Este nome  está na lista :)");
            }
            else if (nome_b == nomes[2])
            {
                Console.WriteLine("ACHEI PORRA!!! Este nome  está na lista :)");
            }
            else if (nome_b == nomes[3])
            {
                Console.WriteLine("ACHEI PORRA!!! Este nome  está na lista :)");
            }
            else if (nome_b == nomes[4])
            {
                Console.WriteLine("ACHEI PORRA!!! Este nome  está na lista :)");
            }
            else if (nome_b == nomes[5])
            {
                Console.WriteLine("ACHEI PORRA!!! Este nome  está na lista :)");
            }
            else if (nome_b == nomes[6])
            {
                Console.WriteLine("ACHEI PORRA!!! Este nome  está na lista :)");
            }
            else if (nome_b == nomes[7])
            {
                Console.WriteLine("ACHEI PORRA!!! Este nome  está na lista :)");
            }
            else if (nome_b == nomes[8])
            {
                Console.WriteLine("ACHEI PORRA!!! Este nome  está na lista :)");
            }
            else if (nome_b == nomes[9])
            {
                Console.WriteLine("ACHEI PORRA!!! Este nome  está na lista :)");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Não Achei, seu nome não está na lista :(");
                Console.ResetColor();
            }
           Console.ResetColor();
        }
    }
}
