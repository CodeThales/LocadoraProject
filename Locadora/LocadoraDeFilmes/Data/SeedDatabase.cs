using LocadoraDeFilmes.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Linq;


namespace LocadoraDeFilmes.Data
{
    public class SeedDatabase
    {
        public static void Initialize(IHost app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var serviceProvider = scope.ServiceProvider;
                var context = serviceProvider.GetRequiredService<LocadoraContext>();
                context.Database.Migrate();

                if (!context.Filme.Any())
                {
                    context.Filme.Add(new Filme { Nome = "Harry Potter e a Pedra Filosofal", Lancamento = new DateTime(2001, 11, 23), Duracao = 159 });
                    context.Filme.Add(new Filme { Nome = "Harry Potter e a Câmara Secreta ", Lancamento = new DateTime(2002, 11, 22), Duracao = 174 });
                    context.Filme.Add(new Filme { Nome = "Harry Potter e o Prisioneiro de Azkaban", Lancamento = new DateTime(2004, 06, 04), Duracao = 144 });
                    context.Filme.Add(new Filme { Nome = "Harry Potter e o Cálice de Fogo", Lancamento = new DateTime(2005, 11, 25), Duracao = 157 });
                    context.Filme.Add(new Filme { Nome = "Harry Potter e a Ordem da Fênix", Lancamento = new DateTime(2007, 07, 11), Duracao = 144 });
                    context.Filme.Add(new Filme { Nome = "Harry Potter e o Enigma do Príncipe", Lancamento = new DateTime(2009, 07, 15), Duracao = 154 });
                    context.Filme.Add(new Filme { Nome = "Harry Potter e as Relíquias da Morte: Parte 1", Lancamento = new DateTime(2010, 11, 19), Duracao = 146 });
                    context.Filme.Add(new Filme { Nome = "Harry Potter e as Relíquias da Morte: Parte 2", Lancamento = new DateTime(2011, 07, 15), Duracao = 130 });
                    context.Filme.Add(new Filme { Nome = "Animais Fantásticos e Onde Habitam", Lancamento = new DateTime(2016, 11, 25), Duracao = 153 });
                    context.Filme.Add(new Filme { Nome = "Animais Fantásticos: Os Crimes de Grindelwald", Lancamento = new DateTime(2018, 11, 15), Duracao = 133 });
                }
                context.SaveChanges();
            }
        }
    }
}
