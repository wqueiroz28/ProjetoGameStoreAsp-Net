using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaGames.Models
{
    public class Genero
    {

        public int  GeneroId { get; set; }

        public string Nome { get; set; }

        public IList<Jogo> Jogos { get; set; }


    }
}
