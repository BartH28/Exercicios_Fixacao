using System;

namespace Produto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o nome do produto");
            string nome = Console.ReadLine();
            Console.WriteLine("Insira a quantidade do produto");
            int quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o preço unitario do produto");
            double preço = double.Parse(Console.ReadLine());

            double total = quantidade * preço;

            if (quantidade <= 5)
            {
                double desconto = (total * 2)/100;
                double totalPagar = total - desconto;
                Console.WriteLine("O total a ser pago será de R$"+ totalPagar);

            }
            else if (quantidade > 5 && quantidade <= 10)
            {
                double desconto_2 = (total * 3)/100;
                double totalPagar_2 = total - desconto_2;
                Console.WriteLine("O total a ser pago será de R$"+ totalPagar_2);
            }
            else
            {
                double desconto_3 = (total * 5)/100;
                double totalPagar_3 = total - desconto_3;
                Console.WriteLine("O total a ser pago será de R$"+ totalPagar_3);
            }
        }
    }
}
