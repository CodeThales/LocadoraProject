using LocadoraDeFilmes.Models;
using System.Collections.Generic;


namespace LocadoraDeFilmes.Services
{
    public interface IFilmeService
    {
        bool Create(Filme filme);
        bool Delete(int? id);
        Filme Get(int? id);
        List<Filme> GetAll(string busca = null, bool ord = false );
        bool Update(Filme filme);
    }
}
