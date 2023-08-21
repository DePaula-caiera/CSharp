using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class UsandoBreak
    {
        public static void Executar()
        {
            Random random = new Random();
            int numero = random.Next(1, 50);

            Console.WriteLine("O número apresentado é {0}.", numero);

            for (int i = 1; i <= 50; i++)
            {
                Console.Write("{0} é o numero que queremos?  ", i);

                if (i == numero)
                {
                    Console.WriteLine("SIM.");
                    break;
                }
                else
                {
                    Console.WriteLine("NÃO.");
                }                
            }

            Console.WriteLine("FIM.");
        }
    }
}



