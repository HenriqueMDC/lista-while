using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosWhile
{
    class Exemplo02
    {
        public Exemplo02()
        {
            int quantidade = 0;
            Console.WriteLine("Valor hora: ");
            string continuar = Console.ReadLine();

            while (continuar == "Sim") 
            {
                Console.Write("Valor hora: ");
                double valorHora = Convert.ToDouble(Console.ReadLine());

                Console.Write("Quantidade de horas: ");
                int quantidadeHora = Convert.ToInt32(Console.ReadLine());

                double salario = valorHora * quantidadeHora;
                Console.WriteLine("Salário: " + salario);

                continuar = Console.ReadLine();
                quantidade = quantidade + 1;
            }

            Console.Write("Quantidade de pessoas cadastrada: " + quantidade);
        }
    }
}
