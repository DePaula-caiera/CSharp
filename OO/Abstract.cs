using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    //Classe abstract pode ser herdada por outras classes, mas não pode ser instanciada.
    //o que for recebiode herança e for abstrato, é necessário declarar/implementar. Ex: Assitente()
    public abstract class Celular
    {
        public abstract string Assistente();

        public string Tocar()
        {
            return "Trim. Trim. Triiim...";
        }
    }

    public class Samsung : Celular
    {
        public override string Assistente() 
        {
            return "Olá. Meu nome é Bixby.";
        }
    }

    public class Iphone : Celular
    {
        public override string Assistente()
        {
            return "Olá. Meu nome é Siri.";
        }

    }

    class Abstract
    {
        public static void Executar()
        {
            var celulares = new List<Celular>
            {
                new Samsung(),
                new Iphone()
            };

            foreach (var celular in celulares) 
            {
                Console.WriteLine(celular.Assistente());
            }
        }
    }
}
