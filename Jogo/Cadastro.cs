using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo
{
    public partial class Cadastro : Form
    {
        DirectoryInfo pasta = new DirectoryInfo(string.Concat(Application.StartupPath, "\\Players\\"));

        public Cadastro()
        {
            InitializeComponent();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
            string[] arq = System.IO.Directory.GetFiles(string.Concat(Application.StartupPath, "\\Players\\"));
            Game.qntdArq = arq.Length;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            int i = 0;
            string[] verificaUser = System.IO.Directory.GetFiles(string.Concat(Application.StartupPath, "\\Players"));
            Game.criaTxt = txtNomeUsuario.Text + ".txt";



            do
            {
                i++;
                string[] splitBarra = verificaUser[i].Split('\\');
                string[] splitPontoTxt = splitBarra.Last().Split('.');


                if (splitPontoTxt[i - 1] == Game.criaTxt)
                {
                    MessageBox.Show("Esse nome de usuário ja existe!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNomeUsuario.Clear();
                    txtSenha.Clear();
                    txtNomeUsuario.Focus();
                    return;
                }
                else
                {
                    while (txtNomeUsuario.Text == "" || txtSenha.TextLength < 5)
                    {
                        MessageBox.Show("Preencha os campos corretamente!", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNomeUsuario.Clear();
                        txtSenha.Clear();
                        txtNomeUsuario.Focus();
                    }
                    break;
                }

                
            } while (i < Game.qntdArq);










            Players player = new Players(txtSenha.Text,0);
            StaticUser.ranking.Add(player);
            StaticUser.OrdenaRank();
            

            MessageBox.Show("Cadastrado com sucesso!");
            FileInfo fi = new FileInfo(String.Concat(pasta.FullName, Game.criaTxt));
            fi.Create().Close();
            this.Close();
        }
    }
}
