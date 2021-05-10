using System;

namespace Exercicio_gasolina
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o tipo de Combustivel voce deseja encher o tanque?  (A - para alcool/ G - para gasolina");
            string tipoCombustivel = Console.ReadLine().ToUpper();
            Console.WriteLine("Quantos litros deseja abastecer?");
            double litros = double.Parse(Console.ReadLine());


            switch (tipoCombustivel)
            {
                case "A":

                    if (litros <= 20)
                    {
                        double preço = 4.90 * litros;
                        double desconto = (preço * 3) / 100;
                        double total = preço - desconto;
                        Console.WriteLine("O preço total a ser pago será: " + total);
                        
                    }
                    else
                    {
                        double preço_20 = 4.90 * litros;
                        double desconto_5 = (preço_20 * 5) / 100;
                        double total_20 = preço_20 - desconto_5;
                        Console.WriteLine("O preço total a ser pago será: " + total_20);
                    }
                    break;
                case "G":
                    if (litros <= 20)
                    {
                        double preço_g = 5.30 * litros;
                        double desconto_g = (preço_g * 4) / 100;
                        double total_g = preço_g - desconto_g;
                        Console.WriteLine("O preço total a ser pago será: " + total_g);
                    }
                    else
                    {
                        double preço_20_g = 5.30 * litros;
                        double desconto_5_g = (preço_20_g * 6) / 100;
                        double total_20_g = preço_20_g - desconto_5_g;
                        Console.WriteLine("O preço total a ser pago será: " + total_20_g);
                    }
                    break;
                default:
                    break;
            }



        }
    }
}
