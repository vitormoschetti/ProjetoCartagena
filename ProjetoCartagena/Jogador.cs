using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCartagena
{
    class Jogador
    {

        public Jogador(int id, string nome, string cor)
        {
            this.id = id;
            this.cor = cor;
            this.nome = nome;
        }

        public Jogador(int id, string senha, string cor, string nome)
        {
            this.id = id;
            this.senha = senha;
            this.cor = cor;
            this.nome = nome;
        }
        public Jogador() {

        }

        public int id { get; set; }
        public string nome { get; set; }
        public string senha { get; set; }
        public string cor { get; set; }
        public int posicao { get; set; }
        public List<string> cartas { get; set; }
    }
}
