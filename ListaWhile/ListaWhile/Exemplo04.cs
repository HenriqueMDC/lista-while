using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosWhile
{
    class Exemplo04
    {
        public Exemplo04()
        {
            int i = 1;
            while (i < 10)
            {
                if (i %2 == 0)
                {
                    Console.Write(i + ",");
                }
                i = i + 1;
            }
            Console.WriteLine("\n\nOBA");
        }
    }
}
