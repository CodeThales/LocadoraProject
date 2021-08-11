using LocadoraDeFilmes.Data;
using LocadoraDeFilmes.Models;
using System.Collections.Generic;
using System.Linq;


namespace LocadoraDeFilmes.Services
{
    public class FilmeSqlService : IFilmeService
    {
        LocadoraContext context;

        public FilmeSqlService(LocadoraContext context)
        {
            this.context = context;
        }

        public List<Filme> GetAll(string busca = null, bool ord = false)
        {
            List<Filme> lista = context.Filme.ToList();
            if (busca != null)
            {
                return lista.FindAll(a =>
                    a.Nome.ToLower().Contains(busca.ToLower())
                );
            }

            if (ord)
            {                
                lista = lista.OrderBy(f => f.Nome).ToList();
                return lista;
            }
            return lista;
        }

        public Filme Get(int? id)
        {
            return context.Filme.Find(id);
        }

        public bool Create(Filme filme)
        {
            try
            {
                context.Filme.Add(filme);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(Filme filme)
        {
            try
            {
                context.Filme.Update(filme);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int? id)
        {
            try
            {
                context.Filme.Remove(Get(id));
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
