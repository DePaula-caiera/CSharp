using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    class ColecoesDictionary
    {
        public static void Executar()
        {
            var filmes = new Dictionary<int, string>();

            filmes.Add(2000, "A Cilada");
            filmes.Add(2002, "Penta - O Filme");
            filmes.Add(2004, "Homem-Aranha");
            filmes.Add(2010, "Velozes e Furiosos - A Batalha");

            if(filmes.ContainsKey(2004))
            {
                Console.WriteLine("2004: " + filmes[2010]);
                Console.WriteLine("2004: " + filmes.GetValueOrDefault(2010));

                Console.WriteLine(filmes.ContainsValue("A Múmia"));

                Console.WriteLine($"Removeu? {filmes.Remove(2004)}");

                filmes.TryGetValue(2010, out string filme2010);
                Console.WriteLine($"Filme {filme2010}!");

                foreach(var chave in filmes.Keys)
                {
                    Console.WriteLine(chave);
                }
                foreach (var valor in filmes.Values)
                {
                    Console.WriteLine(valor);
                }

                foreach(KeyValuePair<int, string> filme in filmes)
                {
                    Console.WriteLine($"O filme '{filme.Value}' é de {filme.Key}.");
                }

                foreach (var filme in filmes)
                {
                    Console.WriteLine($"O filme '{filme.Value}' é do ano de {filme.Key}.");
                }
                {

                }
            }
        }
    }
}
