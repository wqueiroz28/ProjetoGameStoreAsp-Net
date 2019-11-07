using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using LojaGames.Contexts;
using LojaGames.Models;
using Microsoft.EntityFrameworkCore;

namespace LojaGames.Repositories
{
    public class JogoRepository : IJogoRepository
    {

        private GameStoreContext _context;

        public JogoRepository(GameStoreContext context)
        {
            _context = context;
        }

        public void atualizar(Jogo jogo)
        {
            _context.Jogos.Update(jogo);
        }

        public IList<Jogo> BuscaPor(Expression<Func<Jogo, bool>> filtro)
        {
            return _context.Jogos.Where(filtro).ToList();

        }

        public Jogo BuscarPorCodigo(int id)
        {
            return _context.Jogos.Find(id);
        }

        public void Cadastrar(Jogo jogo)
        {
            _context.Jogos.Add(jogo);

        }

        public IList<Jogo> Listar()
        {
            return _context.Jogos.ToList();

        }

        public void Remover(int id)
        {
            var jogo = _context.Jogos.Find(id);
            _context.Jogos.Remove(jogo);
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }
    }
}
