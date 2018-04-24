using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesList03
{
    class Exercicio04
    {
        public Exercicio04()
        {
            int somaAno = 0;

            double somaValor = 0;

            int contador = 0;

            double somaG = 0;
            double somaA = 0;

            string ModeloAux;


            

            Console.WriteLine("Quantos carros deseja cadastrar?");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            Console.Clear();


            while (quantidade > contador)
            {
                contador = contador + 1;

                Console.Write("Modelo do carro: ");
                string modelo = Console.ReadLine();
                ModeloAux = modelo.ToLower();
                ModeloAux.Substring(0, 1);

                Console.Write("\nValor do carro: ");
                double valorCarro = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ano do Carro: ");
                int anoCarro = Convert.ToInt32(Console.ReadLine());

                somaAno = somaAno + anoCarro;

                somaValor = somaValor + valorCarro;

                Console.Clear();

                if (ModeloAux.Substring(0, 1) == "g")
                {
                    somaG = somaG + 1;
                }
                else if ( ModeloAux.Substring(0, 1) == "a")
                {
                    somaA = somaA + 1;
                }
            }
            double mediaAno = somaAno / contador;

            double mediaValor = somaValor / contador;

            Console.WriteLine("Média dos anos: " + mediaAno);
            Console.WriteLine("Media dos valores: " + mediaValor);
            Console.WriteLine("Quantidade de carros que começam com a letra G: " + somaG);
            Console.WriteLine("Quantidade de carros que começam com a letra A: " + somaA);
            
        }
    }
}
