using System;
using System.Windows.Forms;
using System.IO;

namespace Jogo
{
    public partial class frmPrincipal : Form
    {
        DirectoryInfo pasta = new DirectoryInfo(string.Concat(Application.StartupPath, "\\Players"));
    
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Cadastro ca = new Cadastro();
            ca.ShowDialog();
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {   Iniciar ini = new Iniciar();
            ini.ShowDialog();
            this.Hide();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cadastro ca = new Cadastro();
            ca.ShowDialog();
        }

        private void frmPrincipal_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btnIniciar_MouseEnter(object sender, EventArgs e)
        {
            btnIniciar.Image = Properties.Resources.btnIniciar2;
        }

        private void btnIniciar_MouseLeave(object sender, EventArgs e)
        {
            btnIniciar.Image = Properties.Resources.btnIniciar;
        }

        private void btnsair_MouseEnter(object sender, EventArgs e)
        {
            btnsair.Image = Properties.Resources.btnSair21;
        }

        private void btnsair_MouseLeave(object sender, EventArgs e)
        {
            btnsair.Image = Properties.Resources.btnSair1;
        }

        private void btnrRanking_MouseEnter(object sender, EventArgs e)
        {
            btnrRanking.Image = Properties.Resources.btnRank21;
        }

        private void btnrRanking_MouseLeave(object sender, EventArgs e)
        {
            btnrRanking.Image = Properties.Resources.btnRank;
        }

        private void brnCadastro_MouseEnter(object sender, EventArgs e)
        {
            brnCadastro.Image = Properties.Resources.btnCadastrar2;
        }

        private void brnCadastro_MouseLeave(object sender, EventArgs e)
        {
            brnCadastro.Image = Properties.Resources.btnCadastrar;
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (MessageBox.Show("Sair do jogo?","Quit...",MessageBoxButtons.YesNo)==DialogResult.No)
            {
                //Cancela  fechamento
                e.Cancel = true;
            }
            else
            {
                //Salva as alterações
                FileInfo txt = new FileInfo(String.Concat(pasta.FullName, Game.arqTxt));
                if (Game.arqTxt == "")
                {
                    return;
                }
                else
                {
                    txt.Delete();
                    txt.Create().Close();
                }
                foreach (Players item in StaticUser.ranking)
                {
                    String txtCompleto = item.Senha + ';' + item.Tentativas;
                    StreamWriter sw = File.AppendText(txt.FullName);
                    sw.WriteLine(txtCompleto);
                    sw.Close();
                }
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            if (!pasta.Exists)
            {
                pasta.Create();
            }
        }

    }
}
