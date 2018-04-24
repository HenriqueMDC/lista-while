using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesList03
{
    class Exercicio01
    {
        public Exercicio01()
        {
            int quantidade = 0;
            Console.WriteLine("Deseja cadastrar um nome?");
            string continuar = Console.ReadLine();
            continuar = continuar.ToLower();
            while (continuar == "sim")
            {
                Console.Write("Digite um nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Deseja cadastrar novamente?");
                continuar = Console.ReadLine();
                quantidade = quantidade + 1;
            }

        }
    }
}
