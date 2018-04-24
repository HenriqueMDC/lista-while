using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AtividadesList03
{
    class Exercicio02
    {
        public Exercicio02()
        {
            Console.WriteLine("Digite uma idade");
            int idade = Convert.ToInt32(Console.ReadLine());
            int quantidade = 0;
            int numero = Convert.ToInt32(Console.ReadLine());
            while (idade != 128)
            {
                quantidade = quantidade + 1;
                Console.WriteLine("Digite uma idade");
                numero = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
