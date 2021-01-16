using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo
{
    public class Players
    {
        //Variaveis
        public String Senha { get; set; }
        public int Tentativas { get; set; }
        
        //Construtor padrão
        public Players(){}

        //Com parâmetros
        public Players (String nsenha, int ntentativa)
        {
            Senha = nsenha;
            Tentativas = ntentativa;
        }
    }
}
