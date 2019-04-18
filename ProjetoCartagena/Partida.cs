using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCartagena
{
    class Partida
    {
        
        public Partida(int idPartida, string nomePartida, string senhaPartida)
        {
            this.id = idPartida;
            this.nome = nomePartida;
            this.senha = senhaPartida;
        }
        public Partida()
        {
            jogadores = new List<Jogador>();
        }

        public List<Jogador> jogadores { get; set; }
        public int id { get; set; }
        public string nome { get; set; }
        public string senha { get; set; }
        public string historico { get; set; }

    }
}
