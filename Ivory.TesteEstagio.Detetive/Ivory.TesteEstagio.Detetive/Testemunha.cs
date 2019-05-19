using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ivory.TesteEstagio.Detetive
{
    class Testemunha
    {
        private int Criminoso { get; set; }
        private int Local { get; set; }
        private int Arma { get; set; }
        private int NumeroInterrogatorios = 0;


        public Testemunha()
        {
            var criminoso = new Random();
            Criminoso = criminoso.Next(1, 9);

            Thread.Sleep(50);

            var local = new Random();
            Local = local.Next(1, 10);

            Thread.Sleep(50);

            var arma = new Random();
            Arma = arma.Next(1, 7);
        }

        /// <summary>
        /// Função utilizada para interrogar a testemunha sobre os fatos.
        /// </summary>
        /// <param name="criminoso">
        /// Informe um número inteiro para o criminoso a qual gostaria de questionar a testemunha:
        /// 1 - Advogado Sr. Marinho;
        /// 2 - Chef. de Cozinha Tony Gourmet;
        /// 3 - Coveiro Sérgio Sortuno;
        /// 4 - Dançarina Srta. Rosa;
        /// 5 - Florista Dona Branca;
        /// 6 - Médica Dona Violeta;
        /// 7 - Mordomo James;
        /// 8 - Sargento Bigode
        /// </param>
        /// <param name="local">
        /// Informe um número inteiro para o local a qual gostaria de questionar a testemunha:
        /// 1 - Biblioteca;
        /// 2 - Cozinha;
        /// 3 - Hall;
        /// 4 - Escritório;
        /// 5 - Sala de estar;
        /// 6 - Sala de jantar;
        /// 7 - Sala de música;
        /// 8 - Salão de festas;
        /// 9 - Salão de jogos
        /// </param>
        /// <param name="arma">
        /// Informe um número inteiro para a arma a qual gostaria de questionar a testemunha:
        /// 1 - Castiçal;
        /// 2 - Cano;
        /// 3 - Chave inglesa;
        /// 4 - Corda;
        /// 5 - Revólver;
        /// 6 - Faca
        /// </param>
        /// <returns>
        /// A testemunha irá retorna um número inteiro que representa as seguintes repostas:
        /// 0 - Criminoso, local e arma corretos;
        /// 1 - Criminoso incorreto;
        /// 2 - Local incorreto;
        /// 3 - Arma incorreta
        /// </returns>
        public int Interrogar(int criminoso, int local, int arma)
        {
            NumeroInterrogatorios++;

            // Verifica se o que foi interrogado é compatível com o que a testemunha viu.
            var resposta = new List<int>();
            if (criminoso != Criminoso)
            {
                resposta.Add(1);
            }

            if (local != Local)
            {
                resposta.Add(2);
            }

            if (arma != Arma)
            {
                resposta.Add(3);
            }


            if (resposta.Count == 0)
            {
                return 0;
            }
            else if (resposta.Count == 1)
            {
                return resposta[0];
            }
            else
            {
                var repostaAleatoria = new Random();
                return resposta[repostaAleatoria.Next(resposta.Count)];
            }
        }

        public int ObterNumeroInterogatoriosRealizados()
        {
            return NumeroInterrogatorios;
        }
    }
}
