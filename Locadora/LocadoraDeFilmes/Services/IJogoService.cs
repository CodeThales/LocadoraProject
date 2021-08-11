using LocadoraDeFilmes.Models;
using System.Collections.Generic;


namespace LocadoraDeFilmes.Services
{
    public interface IJogoService
    {
        List<Jogo> GetAll();
        Jogo Get(int? id);
        bool Create(Jogo jogo);
        bool Update(Jogo jogo);
        bool Delete(int? id);      
        
    }
}
