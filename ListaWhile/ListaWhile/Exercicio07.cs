using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesList03
{
    class Exercicio07
    {
        public Exercicio07()
        {

            int jogador = 0;
            double somaM = 0;
            double somaF = 0;
            string nomeAux = "0";

            double peso1 = 0, maiorPeso = int.MinValue, menorPeso = int.MaxValue;
            double altura = 0, maiorAltura = int.MinValue, menorAltura = int.MaxValue;
            int cA = 0, maiorCA = int.MinValue, menorCA = int.MaxValue;
            int cV = 0, maiorCV = int.MinValue, menorCV = int.MaxValue;

            string nomeAux1 = "0";
            string nome


            while(jogador < 22)
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                int tamanhoNome = nome.Length;
                int tamanhoNomeAux = 0;
                string nomeAux = "0";
                string modeloAux = Console.ReadLine();
                Console.Write("\nIdade: ");
                int idade = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nPeso: ");
                double peso = Convert.ToDouble(Console.ReadLine());
                Console.Write("\nSexo: ");
                char sexo = Console.ReadLine()[0];
                char SexoAux = Char.ToLower(sexo);
                Console.Write("\nAltura: ");
                double altura = Convert.ToDouble(Console.ReadLine());
                Console.Write("\nGols: ");
                int gols = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nCartões amarelos: ");
                int amarelo = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nCartões vermelhos: ");
                int vermelho = Convert.ToInt32(Console.ReadLine());

                if (Char.ToLower(sexo) == 'm')
                {
                    somaM = somaM + 1;
                }
                if (Char.ToLower(sexo) == 'f')
                {
                    somaF = somaF + 1;
                }
                if (peso > maiorPeso)
                {
                    maiorPeso = peso;
                }
                if (peso < menorPeso)
                {
                    menorPeso = peso;
                }
                if (altura > maiorAltura)
                {
                    maiorAltura = altura;
                }
                if (altura < menorAltura)
                {
                    menorAltura = altura;
                }
                if (tamanhoNome > tamanhoNomeAux)
                {
                    tamanhoNomeAux = tamanhoNome;
                    nomeAux = nome;
                }
                if (tamanhoNome < tamanhoNomeAux)
                {
                    tamanhoNomeAux = tamanhoNome;
                    nomeAux = nome;
                }
                if (cA > maiorCA)
                {
                    maiorCA = cA;
                }
                if (cA < menorCA)
                {
                    menorCA = cA;
                }
                if (cV > maiorCV)
                {
                    maiorCV = cV;
                }
                if (cV < menorCV)
                {
                    menorCV = cV;
                }

                
            }                                                                           
                                                                                        
            Console.WriteLine("Jogador com maior peso: " + maiorPeso);                  
            Console.WriteLine("Jogador com menor peso: " + menorPeso);                  
            Console.WriteLine("Jogador com maior altura: " + maiorAltura);              
            Console.WriteLine("Jogador com menor altura: " + menorAltura);              
            Console.WriteLine("Jogador com maior nome: " + nomeAux);                    
            Console.WriteLine("Jogador com menor nome: " + nomeAux);                    
            Console.WriteLine("Quantidade de jogadores masculinos: " + jogador);        
            Console.WriteLine("Quantidade de jogadores masculinos: " + jogador);        
            Console.WriteLine("Jogador com maior quantidade de cartão amarelo: " + cA); 
            Console.WriteLine("Jogador com menor quantidade de cartão amarelo: " + cA); 
            Console.WriteLine("Jogador com maior quantidade de cartão vermelho: " + cV);
            Console.WriteLine("Jogador com menor quantidade de cartão vermelho: " + cV);
                                                                                        
        }
    }
}
