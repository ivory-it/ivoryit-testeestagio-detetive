using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivory.TesteEstagio.Detetive
{
    class Program
    {
        static void Main(string[] args)
        {
            var testemunha = new Testemunha();

            // Escreva seu código aqui.

            Console.WriteLine("Número de Tentativas: " + testemunha.ObterNumeroInterogatoriosRealizados());
            Console.ReadKey();
        }
    }
}
