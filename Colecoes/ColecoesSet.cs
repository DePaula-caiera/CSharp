using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{  
    class ColecoesSet
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Thrones", 49.90);

            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            var combo = new HashSet<Produto>()
            {
                new Produto("Camisa", 30.00),
                new Produto("10ª Temporada Game of Thrones", 100.90),
                new Produto("Poster", 9.99)
            };

            carrinho.UnionWith(combo);
            Console.WriteLine(carrinho.Count);
            //carrinho.RemoveAt(3);

            foreach (var item in carrinho) 
            {
               // Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.Count);
            // Console.WriteLine(carrinho.LastIndexOf(livro));

            // Estrutura List é indexado (aceita índices) e aceita repetição.
            // Estrutura Set não é indexada e não aceita repetição.
            // Estrutura Set não permite usar 'AddRange', sendo assim é necessário utilizar 'UnionWith'
        }
    }
}
