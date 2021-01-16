using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo
{
    public partial class Pergunta1 : Form
    {
        //VARIÁVEL QUE MOSTRA O TEMPO QUE O USUÁRIO TEM PARA RESPONDER A PERGUNTA.
        int cont;

        public Pergunta1()
        {
            InitializeComponent();
        }

        //Botões das perguntas
        private void button1_Click(object sender, EventArgs e)
        {
            Game.btnCerto();
            timer1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Game.btnErrado();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Game.btnErrado();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Game.btnErrado();
        }

        //FIM DO BLOCO DOS BOTÕES DAS PERGUNTAS.

        //BLOCO DAS PROPRIEDADES E AÇÃO DO BOTÃO DE SAIR.
        private void btnsair_Click(object sender, EventArgs e)
        {
            frmPrincipal frm = new frmPrincipal();
            frm.ShowDialog();
        }

        private void btnsair_MouseEnter(object sender, EventArgs e)
        {
            btnsair.Image = Properties.Resources.btnSair21;
        }

        private void btnsair_MouseLeave(object sender, EventArgs e)
        {
            btnsair.Image = Properties.Resources.btnSair1;
        }

        private void Pergunta1_Load(object sender, EventArgs e)
        {
            cont = 60;
            timer1.Enabled = true;
        }

        //CONTAGEM DO TIMER PARA A PERGUNTA.
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cont == 0)
            {
                frmPrincipal frm = new frmPrincipal();
                frm.ShowDialog();

            }
            cont--;

            label1.Text = cont.ToString();
            label1.Refresh();
        }
    }
}
