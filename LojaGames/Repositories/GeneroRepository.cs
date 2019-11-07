using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using LojaGames.Contexts;
using LojaGames.Models;

namespace LojaGames.Repositories
{
    public class GeneroRepository : IGeneroRepository
    {

        private GameStoreContext _context;

        public GeneroRepository(GameStoreContext context)
        {
            _context = context;
        }

        public void atualizar(Genero genero)
        {
            _context.Generos.Update(genero);

        }

        public IList<Genero> BuscaPor(Expression<Func<Genero, bool>> filtro)
        {
            return _context.Generos.Where(filtro).ToList();
        }

        public Genero BuscarPorCodigo(int id)
        {
            return _context.Generos.Find(id);
        }

        public void Cadastrar(Genero genero)
        {
            _context.Generos.Add(genero);
        }

        public IList<Genero> Listar()
        {
            return _context.Generos.ToList();
        }

        public void Remover(int id)
        {
            var genero = _context.Generos.Find(id);
            _context.Generos.Remove(genero);
        }

        public void salvar()
        {
            _context.SaveChanges();
        }
    }
}
