using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    class ExemploLambda
    {
        public static void Executar()
        {//Todo action não terá retorno (void)
            Action algoNoConsole = () => 
            { 
                Console.WriteLine("Lambda com C#!"); 
            };

            algoNoConsole();

            Func<int> jogarDado = () =>
            {
                Random random = new Random();
                return random.Next(1, 7);
            };

            Console.WriteLine(jogarDado());

            //primeiro parâmetros e por último o tipo de retorno
            Func<int, string> conversorHex = numero => numero.ToString("X");
            Console.WriteLine(conversorHex(1234));

            //o return estaria implícito no Lambda (=>)
            Func<int, int, int, string> formatarData = (dia, mes, ano) =>
                String.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);
            Console.WriteLine(formatarData(29, 09, 2023));
        }
    }
}
