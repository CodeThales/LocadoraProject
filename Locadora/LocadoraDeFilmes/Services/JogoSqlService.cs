using LocadoraDeFilmes.Data;
using LocadoraDeFilmes.Models;
using System.Collections.Generic;
using System.Linq;


namespace LocadoraDeFilmes.Services
{
    public class JogoSqlService : IJogoService
    {
        LocadoraContext context;

        public JogoSqlService(LocadoraContext context)
        {
            this.context = context;
        }

        public List<Jogo> GetAll()
        {
            List<Jogo> lista = context.Jogo.ToList();
            return lista ;
        }

        public Jogo Get(int? id)
        {
            return context.Jogo.Find(id);
        }

        public bool Create(Jogo jogo)
        {
            context.Jogo.Add(jogo);
            context.SaveChanges();
            return true;
        }

        public bool Update(Jogo jogo)
        {
            context.Jogo.Update(jogo);
            context.SaveChanges();
            return true;
        }

        public bool Delete(int? id)
        {
            context.Jogo.Remove(Get(id));
            context.SaveChanges();
            return true;
        }
    }
}
