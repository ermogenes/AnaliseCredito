using System;

namespace AnaliseCredito
{
    class Program
    {
        static void Main(string[] args)
        {
            string valorDigitado, parcelasDigitado, rendaMensalDigitado;
            decimal valor, rendaMensal;
            int parcelas;
            decimal valorParcela, valorMaximoParcela;
            bool valorValido, rendaMensalValido, parcelasValido;
            bool creditoAprovado;

            Console.Clear();
            Console.WriteLine("-- Análise de Crédito --");

            Console.Write("Qual o valor desejado?    ");
            valorDigitado = Console.ReadLine();

            Console.Write("Em quantas parcelas?      ");
            parcelasDigitado = Console.ReadLine();

            Console.Write("Qual a sua renda mensal ? ");
            rendaMensalDigitado = Console.ReadLine();

            valorValido = Decimal.TryParse(valorDigitado, out valor);
            parcelasValido = Int32.TryParse(parcelasDigitado, out parcelas);
            rendaMensalValido = Decimal.TryParse(rendaMensalDigitado, out rendaMensal);

            Console.WriteLine("---");

            if (!valorValido || !parcelasValido || !rendaMensalValido)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Você digitou algum valor inválido. Tente novamente.");
            }
            else
            {
                valorParcela = valor / parcelas;
                valorMaximoParcela = rendaMensal * 0.3m;

                Console.WriteLine($"Valor da parcela...: {valorParcela:C}");
                Console.WriteLine($"Parcela máxima.....: {valorMaximoParcela:C}");

                creditoAprovado = valorParcela <= valorMaximoParcela;

                if (creditoAprovado)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Parabéns, seu crédito foi aprovado! :)");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Desculpe, seu crédito não foi aprovado. :(");
                }
            }            

            Console.ResetColor();
            Console.WriteLine("Obrigado pela preferência!");
        }
    }
}
