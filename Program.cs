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
            bool creditoAprovado;

            Console.Clear();
            Console.WriteLine("-- Análise de Crédito --");

            Console.Write("Qual o valor desejado?    ");
            valorDigitado = Console.ReadLine();

            Console.Write("Em quantas parcelas?      ");
            parcelasDigitado = Console.ReadLine();

            Console.Write("Qual a sua renda mensal ? ");
            rendaMensalDigitado = Console.ReadLine();

            valor = Convert.ToDecimal(valorDigitado);
            parcelas = Convert.ToInt32(parcelasDigitado);
            rendaMensal = Convert.ToDecimal(rendaMensalDigitado);

            Console.WriteLine("---");

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

            Console.ResetColor();
            Console.WriteLine("Obrigado pela preferência!");
        }
    }
}
