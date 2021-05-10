using System;

namespace Exercicio_votos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o ano que voce nasceu?");
            int ano = int.Parse(Console.ReadLine());

            int ano_atual = DateTime.Now.Year;

            int idade_Pessoa = ano_atual - ano;

            if (idade_Pessoa >= 16)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Voce podera votar este ano!!!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Voce não podera votar este ano!!!");
                Console.ResetColor();
            }

            
        }
    }
}
