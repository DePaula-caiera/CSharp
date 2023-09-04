using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{

    public class Cliente
    {
        public string Nome;
        readonly DateTime Nascimento;
        

        public Cliente(string nome, DateTime nascimento)
        {
            Nome = nome;
            Nascimento = nascimento;

            Nascimento = new DateTime(2023, 10, 10);
        }

        public string GetDataNascimento()
        {
            return String.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
        }
    }
    class Readonly
    {
        public static void Executar()
        {
            var novoCliente = new Cliente("Ana Paula Silva", new DateTime(1990, 5, 10));
            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataNascimento());

            //Exemplo de que tipo 'readonly' não pode ser instanciado
            //novoCliente.Nascimento = new DateTime(2023, 10, 10);
        }
    }
}
