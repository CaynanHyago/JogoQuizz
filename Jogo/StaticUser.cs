using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo
{
    public static class StaticUser
    {
        //Lista de usuários
        public static List<Players> ranking = new List<Players>();
        //variavel
        public static int tentativas;
        //Ranking
        public static List<Players> OrdenaRank()
        {
            return ranking.OrderBy(obj => obj.Tentativas).ToList();
        }
    }
}
