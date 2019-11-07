using LojaGames.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LojaGames.Repositories
{
   public interface IJogoRepository
    {

        void Cadastrar(Jogo jogo);
        void atualizar(Jogo jogo);

        void Remover(int id);

        IList<Jogo> Listar();
        Jogo BuscarPorCodigo(int id);
        IList<Jogo> BuscaPor(Expression<Func<Jogo, bool>> filtro);

        void Salvar();

    }
}
