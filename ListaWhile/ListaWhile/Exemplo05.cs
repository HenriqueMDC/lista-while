    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosWhile
{
    class Exemplo05
    {
        public Exemplo05()
        {
            
            int soma = 0, maiorNumero = int.MinValue, menorNumero = int.MaxValue;
            Console.WriteLine("Digite um número, caso queira sair digite 8001");
            string historico = "";

            int numero = Convert.ToInt32(Console.ReadLine());
            int quantidade = 0, quantidadePositivo = 0, quantidadeNegativo = 0, quantidadeNeutro = 0;
            while (numero != 8001)
            {
                soma = soma + numero + 1;
                quantidade = quantidade + 1;

                historico = historico + numero + ", ";

                if (numero > maiorNumero)
                {
                    maiorNumero = numero;
                }
                if (numero < menorNumero)
                {
                    menorNumero = numero;
                }
                if (numero > 0)
                {
                    quantidadePositivo = quantidadePositivo + 1;
                }
                else if (numero != 0)
                {
                    quantidadeNegativo = quantidadeNegativo + 1;
                }
                else
                {
                    quantidadeNeutro = quantidadeNeutro + 1;
                }

                Console.WriteLine("Digite um número, para sair digite 8001");
                numero = Convert.ToInt32(Console.ReadLine());
            }

            Console.Clear();
            double media = soma / quantidade;
            Console.WriteLine("\n\nSoma: " + soma);
            Console.WriteLine("Média: " + media);
            Console.WriteLine("Menor número: " + menorNumero);
            Console.WriteLine("Maior número: " + maiorNumero);
            Console.WriteLine("Quantidade positivos: " + quantidadePositivo);
            Console.WriteLine("Quantidade negativos: " + quantidadeNegativo);
            Console.WriteLine("Quantidade neutro: " + quantidadeNeutro);
            Console.WriteLine("Hitórico: " + historico);
        }
    }
}