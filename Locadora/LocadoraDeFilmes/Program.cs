using LocadoraDeFilmes.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;


namespace LocadoraDeFilmes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var app = CreateHostBuilder(args).Build();
            SeedDatabase.Initialize(app);               
            app.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
