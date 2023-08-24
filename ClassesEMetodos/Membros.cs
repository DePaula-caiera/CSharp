using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Membros
    {
        public static void Executar()
        {
            Pessoa siclano = new Pessoa();
            siclano.Nome = "Endrick Souza";
            siclano.Idade = 17;

            //Console.WriteLine($"{siclano.Nome} tem {siclano.Idade} anos.");

            siclano.ApresentaNoConsole();
            siclano.Zerar();
            siclano.ApresentaNoConsole();
            
            var fulano = new Pessoa();
            fulano.Nome = "Richard Rios";
            fulano.Idade = 25;

            var apresentacaoFulano = fulano.Apresentar();
            Console.WriteLine(apresentacaoFulano);
        }
    }
}
