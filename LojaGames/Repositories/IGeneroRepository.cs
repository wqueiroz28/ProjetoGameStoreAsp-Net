using LojaGames.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LojaGames.Repositories
{
    public interface IGeneroRepository
    {

        void Cadastrar(Genero genero);
        void atualizar(Genero genero);
        void Remover(int id);
        IList<Genero> Listar();
        Genero BuscarPorCodigo(int id);
        IList<Genero> BuscaPor(Expression<Func<Genero, bool>> filtro);
        void salvar();







    }
}
