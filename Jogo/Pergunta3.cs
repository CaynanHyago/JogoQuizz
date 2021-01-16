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
    public partial class Pergunta3 : Form
    {
        int cont;
        public Pergunta3()
        {
            InitializeComponent();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnsair_MouseEnter_1(object sender, EventArgs e)
        {
            btnsair.Image = Properties.Resources.btnSair21;
        }

        private void btnsair_MouseLeave_1(object sender, EventArgs e)
        {
            btnsair.Image = Properties.Resources.btnSair1;
        }

        private void Pergunta3_Load(object sender, EventArgs e)
        {
            cont = 60;
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cont == 0)
            {
                this.Close();
            }
            cont--;

            label1.Text = cont.ToString();
            label1.Refresh();
        }
    }
}
