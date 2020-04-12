using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjFutebol_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Time time1 = new Time("Palmeiras");
            time1.contratarJogador(new Jogador("Alex", 20, 99, 1));
            time1.contratarJogador(new Jogador("Pedro", 22, 96, 2));
            time1.contratarJogador(new Jogador("Leandro", 27, 91, 3));
            time1.contratarJogador(new Jogador("Bruno", 21, 90, 4));
            time1.contratarJogador(new Jogador("Jorge", 23, 92, 5));
            time1.contratarJogador(new Jogador("Eleno", 20, 97, 6));
            time1.contratarJogador(new Jogador("Rodrigo", 20, 80, 7));
            time…
[4:13 PM, 12/04/2020]
        Hebert Facul: using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjFutebol_01
    {
        public class Jogador
        {
            private string nome;
            private int idade;
            private int habilidade;
            private int camisa;
            private int gols;

            public Jogador(string pNome, int pIdade, int pHab, int pCamisa)
            {
                this.nome = pNome;
                this.idade = pIdade;
                this.habilidade = pHab;
                this.camisa = pCamisa;
            }

            public string getNome()
            {
                return nome;
            }

            public int getCamisa()
            {
                return camisa;
            }

            public int getHabilidade()
            {
                return habilidade;
            }

            public int Gols
            {
                get { return gols; }
                set { gols += value; }
            }

            public string getDescricaoJogadores()
            {
                return "Nome: " + this.getNome() +
                    "Idade: " + this.idade +
                    "Habil. : " + this.habilidade +
                    "Camisa: " + this.camisa +
                    "Gols: " + this.Gols;
            }

        }

    }