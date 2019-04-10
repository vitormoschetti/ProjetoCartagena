using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCartagena.model
{
    class Partida
    {
        public List<Jogador> jogadores { get; set; }
        public int id { get; set; }
        public string nome { get; set; }
        public string senha { get; set; }
        public Jogador vez { get; set; }
        public string historico { get; set; }
        public string tabuleiro { get; set; }
    }
}
