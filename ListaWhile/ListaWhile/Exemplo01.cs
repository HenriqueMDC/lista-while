using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosWhile
{
    class Exemplo01
    {
        public Exemplo01()
        {
            int alunoAtual = 0;

            while (alunoAtual < 18)
            {
                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();
                //Incrementa a variavel
                //alunoAtual em 1
                alunoAtual = alunoAtual + 1;
            }
        }
    }
}
