using System;
using System.Drawing;

namespace JoKenPo
{
    class Game
    {
        // Enumeração responsavel pelo resultado da partida
        public enum Resultado
        {
            Ganhar, Perder, Empatar
        }

        // Array para guardar as imagens do game
        public static Image[] images =
            {
                // Adionando as imagens no array
                Image.FromFile("imagens/Pedra.png"),
                Image.FromFile("imagens/Tesoura.png"),
                Image.FromFile("imagens/Papel.png")
            };

        // Guarda a imagem que o PC escolher
        public Image ImgPC
        {
            get;
            private set;
        }

        // Guarda a imagem que o Jogador escolher
        public Image ImgJogador
        {
            get;
            private set;
        }

        // Metodo para calcular a jogada
        public Resultado Jogar(int jogador)
        {
            int pc = JogadorPC();

            // Imagem que o Jogador escolheu
            ImgJogador = images[jogador];

            // Imagem que o PC escolheu
            ImgPC = images[pc];

            // Validar quem ganhou
            if (jogador == pc) // Empate
            {
                return Resultado.Empatar;
            }
            else if ((jogador == 0 && pc == 1) || (jogador == 1 && pc == 2) || (jogador == 2 && pc == 0)) // Jogador Ganhou
            {
                return Resultado.Ganhar;
            }
            else // Jogador Perdeu
            {
                return Resultado.Perder;
            }
        }

        // Metodo para computar a jogada do computador
        private int JogadorPC()
        {
            // Guarda milisegundos que foram computados pelo PC no momento
            int mil = DateTime.Now.Millisecond;

            // Testar possibilidades
            if (mil < 333)
            {
                return 0;
            }
            else if (mil >= 333 && mil < 667)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
    }
}
