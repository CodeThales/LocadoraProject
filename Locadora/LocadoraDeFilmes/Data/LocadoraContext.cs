using LocadoraDeFilmes.Models;
using Microsoft.EntityFrameworkCore;


namespace LocadoraDeFilmes.Data
{
    public class LocadoraContext : DbContext
    {
        public LocadoraContext(DbContextOptions<LocadoraContext> options) : base(options)
        {

        }

        public DbSet<Filme> Filme { get; set; }
        public DbSet<Jogo> Jogo { get; set; }
    }
}
