using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3935_APP3
{
    public partial class Form1 : Form
    {
        int score_jogador = 0, score_pc = 0;
        public Form1()
        {
            InitializeComponent();
            mostra_Score();
        }

        // criar um método para mostrar o score
        private void mostra_Score()
        {
            lbl_jogador.Text=score_jogador.ToString();
            lbl_computador.Text = score_pc.ToString();
        }

        private void rbt_pedra_CheckedChanged(object sender, EventArgs e)
        {
            lbl_escolha_jogador.Text = "A escolha do jogador foi Pedra";
        }

        private void rbt_papel_CheckedChanged(object sender, EventArgs e)
        {
            lbl_escolha_jogador.Text = "A escolha do jogador foi Papel";
        }

        private void rbt_tesoura_CheckedChanged(object sender, EventArgs e)
        {
            lbl_escolha_jogador.Text = "A escolha do jogador foi Tesoura";
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            // Reiniciar o jogo
            // limpar as labels
             // uncheck dos radio buttons
            rbt_pedra.Checked = false;
            rbt_papel.Checked = false;
            rbt_tesoura.Checked = false;

            lbl_escolha_jogador.ResetText();
            lbl_escolha_computador.ResetText();
            lbl_resultado.ResetText();

            // inicializar com zero as variáveis do score
            score_jogador = 0; score_pc = 0;
            mostra_Score();

          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
             * 0 Pedra
             * 1 Papel
             * 2 Tesoura
             */
            int jogador = 0;
            // ver se o jogador efetuou uma escolha
            if(!rbt_pedra.Checked && !rbt_papel.Checked && !rbt_tesoura.Checked)
            {
                MessageBox.Show("Deve escolher um objecto",
                    "Jogo Pedra, Papel, Tesoura");
                return;
            }
            if (rbt_pedra.Checked) jogador = 0;
            if (rbt_papel.Checked) jogador = 1;
            if (rbt_tesoura.Checked) jogador = 2;

            // gerar o objecto do computador
            Random r = new Random();
            // gerar o número do computador
            int pc=r.Next(0,3); // está entre 0 e 2
            //MessageBox.Show(pc.ToString(),
            //        "Jogo Pedra, Papel, Tesoura");
            switch(pc)
            {
                case 0:
                    lbl_escolha_computador.Text = "A escolha do computador foi Pedra";
                    break;
                case 1:
                    lbl_escolha_computador.Text = "A escolha do computador foi Papel";
                    break;
                case 2:
                    lbl_escolha_computador.Text = "A escolha do computador foi Tesoura";
                    break;
            }

            // ver qual o vencedor
            if (jogador == pc)
            {
                lbl_resultado.Text = "O jogo está empatado !";
            }
            else if((jogador == 0) && (pc==2) ||
              (jogador==1) && (pc==0) ||
              (jogador==2) && (pc == 1)){
                lbl_resultado.Text = "O jogador venceu !";
                score_jogador++;
            }
            else
            {
                lbl_resultado.Text = "O computador venceu !";
                score_pc++;
            }
            mostra_Score();
        }
    }
}
