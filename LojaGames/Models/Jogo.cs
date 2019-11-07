using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaGames.Models
{
    public class Jogo
    {

        public int JogoId { get; set; }

        public string nome { get; set; }

        public DateTime DataLancamento { get; set; }

        public bool Disponivel { get; set; }

        public Genero genero { get; set; }

        public int GeneroId { get; set; }
        public Plataforma plataforma { get; set; }
       
    }
}
