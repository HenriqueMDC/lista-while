using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesList03
{
    class Exercicio05
    {
        public Exercicio05()
        {
            double resultado = 0;
            int opcao = 0;

            Console.WriteLine(
                         "\n__________________________________________" +
                         "\n|                  Menu                  |" +
                         "\n|________________________________________|" +
                         "\n|1                   |Somar              |" +
                         "\n|____________________|___________________|" +
                         "\n|2                   |Subtrair           |" +
                         "\n|____________________|___________________|" +
                         "\n|3                   |Multiplicar        |" +
                         "\n|____________________|___________________|" +
                         "\n|4                   |Dividir            |" +
                         "\n|____________________|___________________|" +
                         "\n|5                   |Sair               |" +
                         "\n|____________________|___________________|");

           
            
            while (opcao != 5)
            {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Digite um número: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n\ndigite outro número: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());



                Console.Write("\n\nEscolha uma opção: ");
                opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.Write("\n\nResultado da soma foi: " + (numero1 + numero2));
                }
                else if (opcao == 2)
                {
                    Console.Write("\n\nResultado da subtração foi: " + (numero1 - numero2));
                }
                else if (opcao == 3)
                {
                    Console.Write("\n\nResultado da multiplicação foi: " + (numero1 * numero2));
                }
                else if (opcao == 4)
                {
                    Console.Write("\n\nResultado da divisão foi: " + ( numero1 / numero2));
                }

                Console.WriteLine(
                          "\n__________________________________________" +
                          "\n|                  Menu                  |" +
                          "\n|________________________________________|" +
                          "\n|1                   |Somar              |" +
                          "\n|____________________|___________________|" +
                          "\n|2                   |Subtrair           |" +
                          "\n|____________________|___________________|" +
                          "\n|3                   |Multiplicar        |" +
                          "\n|____________________|___________________|" +
                          "\n|4                   |Dividir            |" +
                          "\n|____________________|___________________|" +
                          "\n|5                   |Sair               |" +
                          "\n|____________________|___________________|" );

            }



        }
    }
}
