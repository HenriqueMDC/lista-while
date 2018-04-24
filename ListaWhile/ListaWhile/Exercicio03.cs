using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AtividadesList03
{
    class Exercicio03
    {
        public Exercicio03()
        {
            
            Console.WriteLine("Digite o peso: ");
            double peso = Convert.ToDouble(Console.ReadLine());
            double contador = 0;

            while ((peso > 0) && ( peso < 300.00))
            {
                contador = contador + 1;

                Console.WriteLine("Digite o peso: ");
                peso = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Quantidade de pessoas cadastradas: " + contador);
        }
    }
}
