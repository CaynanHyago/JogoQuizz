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
    public partial class Iniciar : Form
    {
        String senha = "";

        public Iniciar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            senha = txtSenha.Text;
            Game.arqTxt = txtLogin.Text + ".txt";

            //verifica se o arquivo que no caso é o nome do usuário existe
            for (int i = 0; i < Game.qntdArq; i++)
            {

                if (!File.Exists(string.Concat(Application.StartupPath, "\\Players\\" + Game.arqTxt)))
                {
                    MessageBox.Show("Usuario ou senha digitados, são inválidos!", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLogin.Clear();
                    txtSenha.Clear();


                    while (txtLogin.Text == "" || txtSenha.Text == "")
                    {
                        MessageBox.Show("Preencha os campos corretamente", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtLogin.Clear();
                        txtSenha.Clear();
                        txtLogin.Focus();
                        return;
                    }
                }
                else
                {
                    break;
                }
            }
            //pega a linha do arquivo, no qual contém a senha e as tentativas
            string[] vetSenha = File.ReadAllLines(string.Concat(Application.StartupPath, "\\Players\\" + Game.arqTxt));
            //separa a senha das tentativas
            string[] splitSenha = vetSenha[0].Split(';');
            //verifica a senha
            if (splitSenha[Game.linhaSenha - 1] != senha)
            {
                MessageBox.Show("Usuario ou senha digitados invalido", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLogin.Clear();
                txtSenha.Clear();
                txtLogin.Focus();
            }
            //instancia o aleatorio, no qual será utilizado para a escolha dos forms
            Random random = new Random();

            //chama os comandos do Game
            Game.frm = random.Next(1,10);
            Game.perg = 1;
            Game.trocaForm();
            this.Close();          
        }

        private void Iniciar_Load(object sender, EventArgs e)
        {
            string[] arq = System.IO.Directory.GetFiles(string.Concat(Application.StartupPath, "\\Players"));
            Game.qntdArq = arq.Length;
        }
    }
}
