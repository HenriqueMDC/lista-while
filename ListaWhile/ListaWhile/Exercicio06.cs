using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesList03
{
    class Exercicio06
    {
        public Exercicio06()
        {
            double valor = 0;
            int contador = 0;

            Console.WriteLine(
                "___________________________________________________________________________" +
                "\n|Código|Tipo      |Nome                                       |Valor      |" +
                "\n|______|__________|___________________________________________|___________|" +
                "\n|1     |Bolos     |Bolo Brigadeiro                            |29,50      |" +
                "\n|______|__________|___________________________________________|___________|" +
                "\n|2     |Bolos     |Bolo Floresta Negra                        |2,00       |" +
                "\n|______|__________|___________________________________________|___________|" +
                "\n|3     |Bolos     |Bolo Leite com Nutella                     |29,23      |" +
                "\n|______|__________|___________________________________________|___________|" +
                "\n|4     |Bolos     |Bolo Mousse de Chocolate                   |7,10       |" +
                "\n|______|__________|___________________________________________|___________|" +
                "\n|5     |Bolos     |Bolo Nega Maluca                           |19,33      |" +
                "\n|______|__________|___________________________________________|___________|" +
                "\n|6     |Doces     |Bomba de Creme                             |17,71      |" +
                "\n|______|__________|___________________________________________|___________|" +
                "\n|7     |Doces     |Bomba de Morango                           |4,82       |" +
                "\n|______|__________|___________________________________________|___________|" +
                "\n|8     |Sanduíches|Filé-Mignon com fritas e cheddar           |21,16      |" +
                "\n|______|__________|___________________________________________|___________|" +
                "\n|9     |Sanduíches|Hambúrguer com queijos, champignon e rúcula|12,70      |" +
                "\n|______|__________|___________________________________________|___________|" +
                "\n|10    |Sanduíches|Provolene com salame                       |19,70      |" +
                "\n|______|__________|___________________________________________|___________|" +
                "\n|11    |Sandúiches|Vegetariano de berinjela                   |28,22      |" +
                "\n|______|__________|___________________________________________|___________|" +
                "\n|12    |Pizzas    |Calabresa                                  |8,98       |" +
                "\n|______|__________|___________________________________________|___________|" +
                "\n|13    |Pizzas    |Napolitana                                 |0,42       |" +
                "\n|______|__________|___________________________________________|___________|" +
                "\n|14    |Pizzas    |Peruana                                    |18,36      |" +
                "\n|______|__________|___________________________________________|___________|" +
                "\n|15    |Pizzas    |Portuguesa                                 |27,50      |" +
                "\n|______|__________|___________________________________________|___________|" +
                "\n|16    |          |                                           |Sair       |" +
                "\n|______|__________|___________________________________________|___________|");

            Console.Write("Solicite um produto: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            int produto = Convert.ToInt32(Console.ReadLine());

            int bolo = Convert.ToInt32(Console.ReadLine());

            int doce = Convert.ToInt32(Console.ReadLine());

            int sanduba = Convert.ToInt32(Console.ReadLine());

            int pizza = Convert.ToInt32(Console.ReadLine());

            while (codigo != 16)
            {
                if ((produto > 0) && (produto < 6))
                {
                    bolo = bolo + 1;
                }
                if ((produto > 5) && (produto < 8))
                {
                    doce = doce + 1;
                }
                if ((produto > 7) && (produto < 12))
                {
                    sanduba = sanduba + 1;
                }
                if ((produto > 11) && (produto < 16))
                {
                    pizza = pizza + 1;
                }




                if (produto == 1)
                {
                    valor = 29.50;
                }
                else if (produto == 2)
                {
                    valor = 2.00;
                }
                else if (produto == 3)
                {
                    valor = 29.23;
                }
                else if (produto == 4)
                {
                    valor = 7.10;
                }
                else if (produto == 5)
                {
                    valor = 19.33;
                }
                else if (produto == 6)
                {
                    valor = 17.71;
                }
                else if (produto == 7)
                {
                    valor = 4.82;
                }
                else if (produto == 8)
                {
                    valor = 21.16;
                }
                else if (produto == 9)
                {
                    valor = 12.70;
                }
                else if (produto == 10)
                {
                    valor = 19.70;
                }
                else if (produto == 11)
                {
                    valor = 28.22;
                }
                else if (produto == 12)
                {
                    valor = 8.98;
                }
                else if (produto == 13)
                {
                    valor = 0.42;
                }
                else if (produto == 14)
                {
                    valor = 18.36;
                }
                else if (produto == 15)
                {
                    valor = 27.50;
                }


            }

            double mediaDosProdutos = (bolo + doce + sanduba + pizza) / 4;



            Console.WriteLine("Total de produtos: " + (contador + 1));



            Console.WriteLine("Quantidade de bolos: " + (bolo + 1));
            Console.WriteLine("Quantidade de doces: " + doce);
            Console.WriteLine("Quantidade de sanduíches: " + sanduba);
            Console.WriteLine("Quantidade de pizzas: " + pizza);
            Console.WriteLine("Medias dos produtos: " + mediaDosProdutos);

                             
        }
    }
}
