using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{//classe com modificador sealed não permite herança e nem sobreescrita
 // classe sealed não pode ser herdada, e método sealed não pode ser sobreescrito

    sealed class SemFilho
    {
        public double ValorDaFortuna()
        {
            return 1_410_000.88;
        }
    }

    //class SouFilho : SemFilho
    //{

    //}

    class Avo
    {// virtual permite sobreescrita
        public virtual bool HonrarNomeFamilia()
        {
            return true;
        }
    }

    class Pai : Avo
    {
        public override sealed bool HonrarNomeFamilia()
        {
            return true;
        }
    }

    class FilhoRebelde : Pai
    {
        //public override bool HonrarNomeFamilia()
        //{
        //    return false;
        //}
    }

    class Sealed
    {
        public static void Executar()
        {
            SemFilho semFilho = new SemFilho();
            Console.WriteLine(semFilho.ValorDaFortuna());

            FilhoRebelde filho = new FilhoRebelde();
            Console.WriteLine(filho.HonrarNomeFamilia());
        }
    }
}
