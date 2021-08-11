using LocadoraDeFilmes.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace LocadoraDeFilmes.Services
{
    public class FilmeStaticService : IFilmeService
    {
        List<Filme> GetFilmes()
        {
            List<Filme> listaFilmes = new();
            listaFilmes.Add(new Filme { Id = 1, Nome = "Harry Potter e a Pedra Filosofal", Lancamento = new DateTime(2001, 11, 23), Duracao = 159 });
            listaFilmes.Add(new Filme { Id = 2, Nome = "Harry Potter e a Câmara Secreta ", Lancamento = new DateTime(2002, 11, 22), Duracao = 174 });
            listaFilmes.Add(new Filme { Id = 3, Nome = "Harry Potter e o Prisioneiro de Azkaban", Lancamento = new DateTime(2004, 06, 04), Duracao = 144 });
            listaFilmes.Add(new Filme { Id = 4, Nome = "Harry Potter e o Cálice de Fogo", Lancamento = new DateTime(2005, 11, 25), Duracao = 157 });
            listaFilmes.Add(new Filme { Id = 5, Nome = "Harry Potter e a Ordem da Fênix", Lancamento = new DateTime(2007, 07, 11), Duracao = 144 });
            listaFilmes.Add(new Filme { Id = 6, Nome = "Harry Potter e o Enigma do Príncipe", Lancamento = new DateTime(2009, 07, 15), Duracao = 154 });
            listaFilmes.Add(new Filme { Id = 7, Nome = "Harry Potter e as Relíquias da Morte: Parte 1", Lancamento = new DateTime(2010, 11, 19), Duracao = 146 });
            listaFilmes.Add(new Filme { Id = 8, Nome = "Harry Potter e as Relíquias da Morte: Parte 2", Lancamento = new DateTime(2011, 07, 15), Duracao = 130 });
            listaFilmes.Add(new Filme { Id = 9, Nome = "Animais Fantásticos e Onde Habitam", Lancamento = new DateTime(2016, 11, 25), Duracao = 153 });
            listaFilmes.Add(new Filme { Id = 10, Nome = "Animais Fantásticos: Os Crimes de Grindelwald", Lancamento = new DateTime(2018, 11, 15), Duracao = 133 });

            return listaFilmes;

        }

        public List<Filme> GetAll(string busca = null, bool ord = false)
        {
            if (busca != null)
            {
                return GetFilmes().FindAll(a =>
                    a.Nome.ToLower().Contains(busca.ToLower())
                );
            }

            if (ord)
            {
                var lista = GetFilmes();                
                lista = lista.OrderBy(p => p.Nome).ToList();
                return lista;
            }
            return GetFilmes();
        }
        public bool Create(Filme filme)
        {

            try
            {
                List<Filme> pacientes = GetFilmes();
                filme.Id = pacientes.Count() + 1;
                pacientes.Add(filme);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Filme Get(int? id)
        {
            return GetFilmes().FirstOrDefault(f => f.Id == id);
        }

        public bool Update(Filme filme)
        {
            return false;
        }

        public bool Delete(int? id)
        {
            return false;
        }
    }
}
 

