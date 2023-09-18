using System.Collections;

namespace CursoCSharp.Colecoes
{
    class ColecoesQueue
    {
        public static void Executar()
        {
            var fila = new Queue<string>();

            fila.Enqueue("Fulano");
            fila.Enqueue("Sicrano");
            fila.Enqueue("Beltrano");
            fila.Enqueue("Beltrano");

            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count());

            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Count());

            foreach (var pessoa in fila)
            {
                Console.WriteLine(pessoa);
            }


            var teste = new Queue();
            teste.Enqueue(3);
            teste.Enqueue("Item");
            teste.Enqueue(true);
            teste.Enqueue(3.14);

            Console.WriteLine(teste.Contains("item"));
            Console.WriteLine(teste.Contains("Item"));

        }
    }
}
