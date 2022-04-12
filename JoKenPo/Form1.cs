using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoKenPo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPedra_Click(object sender, EventArgs e)
        {
            StartGame(0);
        }

        private void btnPapel_Click(object sender, EventArgs e)
        {
            StartGame(2);
        }

        private void btnTesoura_Click(object sender, EventArgs e)
        {
            StartGame(1);
        }

        // Inicia o Gmae
        private void StartGame(int opcao)
        {
            // Label fica invisivel quando StartGame for iniciado
            labelResultado.Visible = false;

            // Objeto Jogo
            Game jogo = new Game();

            // Testa o objeto Jogo
            switch (jogo.Jogar(opcao))
            {
                case Game.Resultado.Ganhar:

                    // Definir imagem do PictureBox
                    picResultado.BackgroundImage = Image.FromFile("imagens/Ganhar.png");

                    goto default;
                case Game.Resultado.Perder:

                    // Definir imagem do PictureBox
                    picResultado.BackgroundImage = Image.FromFile("imagens/Perder.png");

                    goto default;
                case Game.Resultado.Empatar:

                    // Definir imagem do PictureBox
                    picResultado.BackgroundImage = Image.FromFile("imagens/Empatar.png");

                    goto default;
                default:

                    pictureBox1.Image = jogo.ImgJogador;
                    pictureBox2.Image = jogo.ImgPC;
                    break;
            }
        }
    }
}
