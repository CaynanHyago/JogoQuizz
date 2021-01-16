using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo
{
    //ESSA CLASSE ESTÁTICA SERVE PARA AS AÇÕES DENTRO DO JOGO, COMO BOTÕES, AREA DE CADASTRO E ETC.
    public static class Game
    {
        //VARIÁVEIS.
        public static int perg;
        public static int frm;
        public static int linhaSenha = 1;
        public static String arqTxt;
        public static String criaTxt;

        //qntd arquivos possuem no diretório Player
        public static int qntdArq;

        //MÉTODOS AUXILIARES DO JOGO

        //MÉTODO QUE INDICA QUAL SERÁ A PROXIMA PERGUNTA
        public static void trocaForm()
        {
            switch (frm)
            {
                case 1:
                    Pergunta1 p1 = new Pergunta1();
                    p1.Show();
                    break;
                case 2:
                    Pergunta2 p2 = new Pergunta2();
                    p2.Show();
                    break;
                case 3:
                    Pergunta3 p3 = new Pergunta3();
                    p3.Show();
                    break;
                case 4:
                    Pergunta4 p4 = new Pergunta4();
                    p4.Show();
                    break;
                case 5:
                    Pergunta5 p5 = new Pergunta5();
                    p5.Show();
                    break;
                case 6:
                    pergunta6 p6 = new pergunta6();
                    p6.Show();
                    break;
                case 7:
                    Pergunta7 p7 = new Pergunta7();
                    p7.Show();
                    break;
                case 8:
                    Pergunta8 p8 = new Pergunta8();
                    p8.Show();
                    break;
                case 9:
                    Pergunta9 p9 = new Pergunta9();
                    p9.Show();
                    break;
                case 10:
                    Pergunta10 p10 = new Pergunta10();
                    p10.Show();
                    if (perg < 10)
                    {
                        frm = perg;
                    }
                    break;
            }

        }

        //MÉTODO QUE ANALISA QUANDO O JOGO TERMINARÁ
        public static void analisaPerg()
        {
            switch (perg)
            {
                case 1:
                    perg += 1;
                    break;
                case 2:
                    perg += 1;
                    break;
                case 3:
                    perg += 1;
                    break;
                case 4:
                    perg += 1;
                    break;
                case 5:
                    perg += 1;
                    break;
                case 6:
                    perg += 1;
                    break;
                case 7:
                    perg += 1;
                    break;
                case 8:
                    perg += 1;
                    break;
                case 9:
                    perg += 1;
                    break;
                case 10:
                    MessageBox.Show("Parabéns, você completou o DESAFIO!");
                    frmPrincipal frm = new frmPrincipal();
                    frm.Close();
                    break;
            }
        }

        //MÉTODO PARA OS BOTÕES CERTOS
        public static void btnCerto()
        {
            MessageBox.Show("Parabéns você acertou");
            frm += 1;
            perg += 1;
            trocaForm();
            analisaPerg();
        }

        //MÉTODO PARA OS BOTÕES ERRADOS
        public static void btnErrado()
        {
            MessageBox.Show("Parabéns você errou");
            StaticUser.tentativas+=1;
        }
    }
}
